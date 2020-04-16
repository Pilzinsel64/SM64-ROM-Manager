using System;
using System.Collections.Generic;
using global::System.Drawing;
using global::System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using global::Pilz.S3DFileParser;
using global::SM64Lib.Data;
using global::SM64Lib.Model.Fast3D.DisplayLists;
using global::SM64Lib.Model.Fast3D.DisplayLists.Script;
using global::SM64Lib.Model.Fast3D.DisplayLists.Script.Commands;
using global::SM64Lib.SegmentedBanking;

namespace SM64Lib.Model.Conversion.Fast3DParsing
{
    public class Fast3DParser
    {

        /// <summary>Parse a Displaylist to an Object3D.</summary>
        /// <param name="obj">The Object3D where the model should be parsed to.</param>
        /// <param name="dl">The Displaylist which should be parsed.</param>
        /// <param name="rommgr">The RomManager Instance to use.</param>
        /// <param name="AreaID">The Area ID if avaiable.</param>
        public static void Convert(Object3D obj, DisplayList dl, RomManager rommgr, byte? AreaID)
        {
            if (dl.Script.Count == 0 || dl.GeoPointer is null)
                return;
            int cmdIndex = 0;
            DisplayListCommand cmd = null;
            byte[] cmdarr = null;
            var knownTextures = new Dictionary<int, Material>();
            var knownColors = new Dictionary<int, Color>();
            var knownVertices = new Dictionary<int, Vertex>();
            var knownNormals = new Dictionary<int, Normal>();
            var knownUVs = new Dictionary<int, UV>();
            var knownVertexColors = new Dictionary<int, VertexColor>();
            var knownShading = new Dictionary<int, Color>();
            var dicVertexColorShading = new Dictionary<Color, VertexColor>();
            var pointbuffer = new Pilz.S3DFileParser.Point[16];
            var scaledVertices = new List<UV>();
            Material curTexture = null;
            Size curTexSize = default;
            int curTexSegAddr = -1;
            int curTexWrapT = 10497;
            int curTexWrapS = 10497;
            var curTexScale = new System.Numerics.Vector2(1.0F, 1.0F);
            var curTexPalette = Array.Empty<byte>();
            int curTexPaletteSegAddr = -1;
            N64Graphics.N64Codec? curTexFormat = default;
            uint curGeometryMode = 0x22205;
            Mesh curMesh = null;
            Color? curColor = default;
            TextureLoadedInfos curTexLoadedInfos = null;
            bool useUVOffsetFix = true;
            int dlDepth = 0;

            // Load Main Segmented Bank
            var curSeg = GetSegBank(rommgr, dl.GeoPointer.SegPointer, AreaID);
            if (curSeg is null) return;

            curMesh = new Mesh();

            while (cmdIndex < dl.Script.Count /*&& dl.Script[cmdIndex].CommandType != CommandTypes.EndDisplaylist*/)
            {
                cmd = dl.Script[cmdIndex];
                cmdarr = cmd.ToArray();
                var switchExpr = cmd.CommandType; // &H20000
                switch (switchExpr)
                {
                    case CommandTypes.DisplayList:
                        if (cmdarr[1] != 1)
                            dlDepth += 1;
                        break;

                    case CommandTypes.EndDisplaylist:
                        if (dlDepth > 0)
                            dlDepth -= 1;
                        break;

                    case CommandTypes.ClearGeometryMode:
                        {
                            curGeometryMode = curGeometryMode & ~F3D_CLEARGEOMETRYMODE.GetGeometryMode(cmd);
                            break;
                        }

                    case CommandTypes.SetGeometryMode:
                        {
                            curGeometryMode = curGeometryMode | F3D_CLEARGEOMETRYMODE.GetGeometryMode(cmd);
                            break;
                        }

                    case CommandTypes.Movemem:
                        {
                            int segAddr = F3D_MOVEMEM.GetSegmentedOffset(cmd);
                            byte smode = F3D_MOVEMEM.GetLightValueMode(cmd);
                            if (smode == 0x86) // Load Shading Light (Diffuse) Color
                            {
                                if (knownShading.ContainsKey(segAddr))
                                {
                                    curColor = knownShading[segAddr];
                                }
                                else
                                {
                                    var colordata = new byte[4];
                                    var seg = rommgr.GetSegBank(Conversions.ToByte(segAddr >> 24), AreaID);

                                    // Read Color Data
                                    seg.Data.Position = segAddr & 0xFFFFFF;
                                    seg.Data.Read(colordata, 0, colordata.Length);
                                    curColor = Color.FromArgb(0xFF, colordata[0], colordata[1], colordata[2]);
                                    if (!dicVertexColorShading.ContainsKey((Color)curColor))
                                    {
                                        // Create new Vertex Color
                                        var vc = new VertexColor() { R = colordata[0] / 256.0F, G = colordata[1] / 256.0F, B = colordata[2] / 256.0F, A = 1.0F };
                                        dicVertexColorShading.Add((Color)curColor, vc);
                                    }

                                    // Set as Vertex Color
                                    knownShading.Add(segAddr, (Color)curColor);
                                }
                            }

                            break;
                        }

                    case CommandTypes.Loadtlut:
                        {
                            byte paletteTileDescritpr = cmdarr[4];
                            ushort numColorsToLoadInPalette;
                            curTexPaletteSegAddr = curTexSegAddr;
                            cmd.Position = 5;
                            numColorsToLoadInPalette = (ushort)(cmd.ReadUInt16() >> 6);
                            var seg = rommgr.GetSegBank(Conversions.ToByte(curTexPaletteSegAddr >> 24), AreaID);
                            curTexPalette = new byte[numColorsToLoadInPalette * 2 + 1 + 1];
                            int offset = curTexPaletteSegAddr & 0xFFFFFF;
                            for (int i = 1, loopTo = numColorsToLoadInPalette + 1; i <= loopTo; i++)
                            {
                                int ii = i * 2 - 2;
                                seg.Data.Position = offset + ii;
                                curTexPalette[ii] = Conversions.ToByte(seg.Data.ReadByte());
                                curTexPalette[ii + 1] = Conversions.ToByte(seg.Data.ReadByte());
                            }

                            break;
                        }

                    case CommandTypes.Triangle1:
                        {
                            var f = new Face();
                            if (curTexFormat is object)
                            {
                                ProcessTexture(obj, rommgr, AreaID, dl, (N64Graphics.N64Codec)curTexFormat, knownTextures, ref curTexture, curTexSegAddr, curTexSize, curTexWrapT, curTexWrapS, curTexScale, curTexPalette, curTexPaletteSegAddr, curColor, ref curTexLoadedInfos);
                                f.Material = curTexture;
                            }

                            for (int i = 1; i <= 3; i++)
                            {
                                byte pindex = F3D_TRI1.GetVertice(cmd, Conversions.ToByte(i));
                                if (pindex >= pointbuffer.Length)
                                    return;
                                var p = pointbuffer[pindex];
                                if (p is object)
                                    f.Points.Add(p);
                            }

                            // Shading (as Vertex Color)
                            if (curTexture?.Color is object && (curGeometryMode & (long)0x20000) != 0)
                            {
                                var vc = dicVertexColorShading[(Color)curTexture.Color];
                                foreach (Pilz.S3DFileParser.Point p in f.Points)
                                {
                                    if (p.VertexColor is null)
                                    {
                                        if (dicVertexColorShading.ContainsKey((Color)curTexture.Color))
                                        {
                                            p.VertexColor = vc;
                                            if (!curMesh.VertexColors.Contains(vc))
                                            {
                                                curMesh.VertexColors.Add(vc);
                                            }
                                        }
                                    }
                                }
                            }

                            curMesh.Faces.Add(f);
                            break;
                        }

                    case CommandTypes.Vertex:
                        {
                            byte num = F3D_VTX.GetNumberOfVertices(cmd);
                            byte startindex = F3D_VTX.GetStartIndexInVertexBuffer(cmd);
                            short datalength = F3D_VTX.GetLengthOfVertexData(cmd);
                            int segAddr = F3D_VTX.GetSegmentedAddress(cmd);
                            if (num > 0)
                            {
                                for (int i = 0, loopTo1 = num; i <= loopTo1; i++)
                                {
                                    var p = new Pilz.S3DFileParser.Point();
                                    int curSegAddr = segAddr + i * 0x10;
                                    var cs = GetSegBank(rommgr, curSegAddr, AreaID);
                                    if (cs is null)
                                        continue;

                                    // Vertex
                                    if (knownVertices.ContainsKey(curSegAddr))
                                    {
                                        p.Vertex = knownVertices[curSegAddr];
                                    }
                                    else
                                    {
                                        var vert = GetVertexFromStream(cs.Data, cs.BankOffsetFromSegAddr(curSegAddr), dl.GeoPointer.ModelOffset, dl.GeoPointer.ModelScale);
                                        p.Vertex = vert;
                                        curMesh.Vertices.Add(vert);
                                        knownVertices.Add(curSegAddr, vert);
                                    }

                                    // UV
                                    if (knownUVs.ContainsKey(curSegAddr))
                                    {
                                        p.UV = knownUVs[curSegAddr];
                                    }
                                    else
                                    {
                                        var uv = GetUVFromStream(cs.Data, cs.BankOffsetFromSegAddr(curSegAddr), curTexScale, curTexSize, useUVOffsetFix);
                                        p.UV = uv;
                                        curMesh.UVs.Add(uv);
                                        knownUVs.Add(curSegAddr, uv);
                                    }

                                    if ((curGeometryMode & (long)0x20000) == 0)
                                    {
                                        // Vertex Color
                                        if (knownVertexColors.ContainsKey(curSegAddr))
                                        {
                                            p.VertexColor = knownVertexColors[curSegAddr];
                                        }
                                        else
                                        {
                                            var vc = GetVertexColorFromStream(cs.Data, cs.BankOffsetFromSegAddr(curSegAddr));
                                            p.VertexColor = vc;
                                            curMesh.VertexColors.Add(vc);
                                            knownVertexColors.Add(curSegAddr, vc);
                                        }
                                    }
                                    // Normal
                                    else if (knownNormals.ContainsKey(curSegAddr))
                                    {
                                        p.Normal = knownNormals[curSegAddr];
                                    }
                                    else
                                    {
                                        var n = GetNormalFromStream(cs.Data, cs.BankOffsetFromSegAddr(curSegAddr));
                                        p.Normal = n;
                                        curMesh.Normals.Add(n);
                                        knownNormals.Add(curSegAddr, n);
                                    }

                                    pointbuffer[startindex + i] = p;
                                }
                            }

                            break;
                        }

                    case CommandTypes.SetImage:
                        {
                            int newAddr = F3D_SETIMG.GetSegmentedAddress(cmd);
                            if ((uint)newAddr != 0xFFFFFFFF)
                            {
                                curTexSegAddr = newAddr;
                            }

                            break;
                        }

                    case CommandTypes.SetTileSize:
                        {
                            curTexSize = F3D_SETTILESIZE.GetSize(cmd);
                            break;
                        }

                    case CommandTypes.SetTile:
                        {
                            cmd.Position = 4;
                            int checkVal = cmd.ReadInt32();
                            cmd.Position = 0;
                            if (checkVal != 0x7000000)
                            {
                                if ((checkVal >> 24 & 0xFF) == 0)
                                {
                                    curTexFormat = F3D_SETTILE.GetTextureFormat(cmd);
                                }

                                curTexWrapT = F3D_SETTILE.GetWrapT(cmd);
                                curTexWrapS = F3D_SETTILE.GetWrapS(cmd);
                            }

                            break;
                        }

                    case CommandTypes.Texture:
                        {
                            if ((curGeometryMode & (long)0x40000) == 0x40000)
                            {
                                curTexSize = F3D_TEXTURE.GetTextureSize(cmd);
                            }
                            else
                            {
                                curTexScale = F3D_TEXTURE.GetTextureScaling(cmd);
                            }

                            break;
                        }

                    case CommandTypes.SetOtherMode_H:
                        {
                            uint bits = F3D_SETOTHERMODE_H.GetModeBits(cmd);
                            bool nearestNeighbor = (bits & (long)0x2000) == 0;
                            useUVOffsetFix = !nearestNeighbor;
                            break;
                        }
                }

                cmdIndex += 1;
            }

            //if (curMesh.Faces.Any())
                obj.Meshes.Add(curMesh);
        }

        /// <summary>Parse a Displaylist to an Object3D.</summary>
        /// <param name="obj">The Object3D where the model should be parsed to.</param>
        /// <param name="dl">The Displaylist which should be parsed.</param>
        /// <param name="rommgr">The RomManager Instance to use.</param>
        /// <param name="AreaID">The Area ID if avaiable.</param>
        public static Task ConvertAsync(Object3D obj, DisplayList dl, RomManager rommgr, byte? AreaID)
        {
            var t = new Task(() => Convert(obj, dl, rommgr, AreaID));
            t.Start();
            return t;
        }

        private static SegmentedBank GetSegBank(RomManager rommgr, int segAddr, byte? AreaID)
        {
            var seg = rommgr.GetSegBank(Conversions.ToByte(segAddr >> 24), AreaID);
            seg.ReadDataIfNull(rommgr.RomFile);
            return seg;
        }

        private static void ProcessTexture(Object3D obj, RomManager rommgr, byte? AreaID, DisplayList dl, N64Graphics.N64Codec texFormat, Dictionary<int, Material> knownTextures, ref Material curTexture, int curTexSegAddr, Size curTexSize, int curTexWrapT, int curTexWrapS, System.Numerics.Vector2 curTexScale, byte[] curTexPalette, int curTexPaletteSegAddr, Color? curColor, ref TextureLoadedInfos curTexLoadedInfos)
        {
            if (curTexSegAddr < 0)
                return;
            if (knownTextures.ContainsKey(curTexSegAddr))
            {
                curTexture = knownTextures[curTexSegAddr];
            }
            else
            {
                try
                {
                    var mat = new Material();
                    mat.Wrap = new System.Numerics.Vector2(curTexWrapT, curTexWrapS);
                    mat.Scale = curTexScale;
                    mat.Color = curColor;
                    var seg = GetSegBank(rommgr, curTexSegAddr, AreaID);
                    if (seg is null)
                        return;
                    GetTextureImage(seg.Data, seg.BankOffsetFromSegAddr(curTexSegAddr), mat, texFormat, curTexSize, curTexPalette);
                    if (mat.Image is object)
                    {
                        mat.Tag = new TextureLoadedInfos(Microsoft.VisualBasic.Conversion.Hex(curTexSegAddr), texFormat, curTexSegAddr, curTexPaletteSegAddr, seg.SegToRomAddr(curTexSegAddr), seg.SegToRomAddr(curTexPaletteSegAddr), mat.Image.Size);
                    }

                    curTexture = mat;
                    knownTextures.Add(curTexSegAddr, mat);
                    if (!obj.Materials.ContainsKey(Conversions.ToString(curTexSegAddr)))
                    {
                        obj.Materials.Add(Conversions.ToString(curTexSegAddr), mat);
                    }
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox(ex.Message);
                }
            }
        }

        private static void GetTextureImage(Stream s, int pos, Material mat, N64Graphics.N64Codec texFormat, Size curTexSize, byte[] curTexPalette)
        {
            // Create Image & Graphics
            mat.Image = new Bitmap(curTexSize.Width, curTexSize.Height);
            var g = Graphics.FromImage(mat.Image);

            // Get Texture Data
            var bytes = new byte[(N64Graphics.N64Graphics.PixelsToBytes(texFormat, curTexSize.Width * curTexSize.Height))];
            s.Position = pos;
            s.Read(bytes, 0, bytes.Length);
            try
            {
                // Decode Texture
                N64Graphics.N64Graphics.RenderTexture(g, bytes.ToArray(), curTexPalette, 0, curTexSize.Width, curTexSize.Height, 1, texFormat, N64Graphics.N64IMode.AlphaCopyIntensity);
            }
            catch (Exception)
            {
            }
        }

        private static Vertex GetVertexFromStream(Stream s, int vtStart, System.Numerics.Vector3 modelOffset, System.Numerics.Vector3 modelScale)
        {
            var vert = new Vertex();
            var br = new BinaryStreamData(s);
            s.Position = vtStart;
            vert.X = br.ReadInt16() + modelOffset.X;
            vert.Y = br.ReadInt16() + modelOffset.Y;
            vert.Z = br.ReadInt16() + modelOffset.Z;
            vert.X *= modelScale.X;
            vert.Y *= modelScale.Y;
            vert.Z *= modelScale.Z;
            return vert;
        }

        private static UV GetUVFromStream(Stream s, int vtStart, System.Numerics.Vector2 curTexScale, Size curTexSize, bool useUVOffsetFix)
        {
            var uv = new UV();
            var br = new BinaryStreamData(s);
            s.Position = vtStart + 8;
            uv.U = br.ReadInt16() * curTexScale.X;
            uv.V = br.ReadInt16() * curTexScale.Y;
            if (useUVOffsetFix) // Fixes UVs offset
            {
                uv.U += 16;
                uv.V += 16;
            }

            uv.U /= curTexSize.Width * 32.0F;
            uv.V /= curTexSize.Height * 32.0F;
            return uv;
        }

        private static Normal GetNormalFromStream(Stream s, int vtStart)
        {
            var normal = new Normal();
            s.Position = vtStart + 12;
            normal.X = s.ReadByte() / 255.0F;
            normal.Y = s.ReadByte() / 255.0F;
            normal.Z = s.ReadByte() / 255.0F;
            // normal.A = s.ReadByte ???

            return normal;
        }

        private static VertexColor GetVertexColorFromStream(Stream s, int vtStart)
        {
            var normal = new VertexColor();
            s.Position = vtStart + 12;
            normal.R = s.ReadByte() / 255.0F;
            normal.G = s.ReadByte() / 255.0F;
            normal.B = s.ReadByte() / 255.0F;
            normal.A = s.ReadByte() / 255.0F;
            return normal;
        }
    }
}