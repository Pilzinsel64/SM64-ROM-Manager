using System;
using System.Collections.Generic;
using System.Data;
using global::System.Drawing;
using global::System.IO;
using System.Linq;
using global::System.Numerics;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64Lib.Data;
using global::SM64Lib.Geolayout;
using global::SM64Lib.Levels.ScrolTex;
using global::SM64Lib.Model.Fast3D;
using global::SM64Lib.Model.Fast3D.DisplayLists.Script.Commands;
using global::SM64Lib.N64Graphics;
using Z.Collections.Extensions;

namespace SM64Lib.Model.Conversion.Fast3DWriting
{
    public class Fast3DWriter
    {
        public class ConvertResult
        {
            public States State { get; set; } = States.Successfully;
            public uint PtrStart { get; set; } = 0;
            public uint PtrVertex { get; set; } = 0;
            public List<Geopointer> PtrGeometry { get; private set; } = new List<Geopointer>();
            public List<ManagedScrollingTexture> ScrollingCommands { get; private set; } = new List<ManagedScrollingTexture>();
            public Dictionary<short, string> ScrollingNames { get; private set; } = new Dictionary<short, string>();
            public MemoryStream Data { get; private set; } = new MemoryStream();

            public enum States
            {
                Successfully,
                Error
            }
        }

        public struct ScrollingInfo
        {
            public int TextureAddress { get; set; }
            public string Name { get; set; }
        }

        public class ConvertSettings
        {
            public uint? SegmentedAddress { get; set; }
            public uint SizeLimit { get; set; } = 0x150000;
            public double Scale { get; set; } = 500;
            public Vector3 OffsetPosition { get; set; } = Vector3.Zero;
            public ReduceVericesLevel ReduceVertLevel { get; set; } = ReduceVericesLevel.Level1;
            public string ColorTexData { get; set; } = "";
            public string GeoModeData { get; set; } = "";
            public string TexTypeData { get; set; } = "";
            public bool ResizeTextures { get; set; } = false;
            public bool CenterModel { get; set; } = false;
            public Fog Fog { get; set; } = null;
            public string CollisionData { get; set; } = "";
            public sbyte ForceDisplaylist { get; set; } = -1;
            public bool OptimizeTransparencyChecks { get; set; } = false;
            public TextureFormatSettings TextureFormatSettings { get; set; } = null;

            public bool EnableFog
            {
                get
                {
                    return Fog is object;
                }
            }
        }

        public class SettingsException : Exception
        {
            public SettingsException() : base("Undefined ConvertSettings error.")
            {
            }

            public SettingsException(string message) : base(message)
            {
            }
        }

        /// <summary>
        /// Reduces the number of duplicate verticies.
        /// </summary>
        public enum ReduceVericesLevel : byte
        {
            /// <summary>
            /// No reduction.
            /// </summary>
            Level0 = 0,
            /// <summary>
            /// Reduce only in the same 0x04 group. (Best choise!)
            /// </summary>
            Level1 = 1,
            /// <summary>
            /// Reduce and push up. (A little buggy!)
            /// </summary>
            Level2 = 2
        }

        private enum MaterialType
        {
            None,
            TextureSolid,
            TextureAlpha,
            TextureTransparent,
            ColorSolid,
            ColorTransparent
        }

        private class Vertex
        {
            public short X { get; set; } = 0;
            public short Y { get; set; } = 0;
            public short Z { get; set; } = 0;
        }

        private class Normal
        {
            public byte A { get; set; } = 0;
            public byte B { get; set; } = 0;
            public byte C { get; set; } = 0;
            public byte D { get; set; } = 0;
        }

        private class VertexColor
        {
            public byte R { get; set; } = 0;
            public byte G { get; set; } = 0;
            public byte B { get; set; } = 0;
            public byte A { get; set; } = 0;
        }

        private class TexCord
        {
            public float U { get; set; } = 0;
            public float V { get; set; } = 0;
        }

        private class Material
        {
            public string Name { get; set; } = "";
            public bool HasTexture { get; set; }
            public bool HasPalette { get; set; }
            public bool HasTextureAlpha { get; set; }
            public bool HasTransparency { get; set; }
            public bool EnableTextureColor { get; set; }
            public bool EnableAlphaMask { get; set; } // For I4/I8 textures.
            public bool CameFromBMP { get; set; } // For I4/I8 textures.
            public uint Color { get; set; } = 0;
            public byte Opacity { get; set; } = 0;
            public byte OpacityOrg { get; set; } = 0;
            public uint Offset { get; set; } = 0;
            public uint PaletteOffset { get; set; } = 0;
            public uint Size { get; set; } = 0;
            public uint PaletteSize { get; set; } = 0;
            public uint TexWidth { get; set; } = 0;
            public uint TexHeight { get; set; } = 0;
            public MaterialType Type { get; set; } = MaterialType.None;
            public N64Codec TexType { get; set; } = N64Codec.RGBA16;
            public ushort Collision { get; set; } = 0;
            public byte Collisionp1 { get; set; } = 0;
            public byte Collisionp2 { get; set; } = 0;
            public bool EnableGeoMode { get; set; }
            public uint GeoMode { get; set; } = 0;
            public TextureEntry Texture { get; set; } = null;
            public bool EnableScrolling { get; set; } = false;
            public DisplaylistSelectionSettings DisplaylistSelection { get; set; } = new DisplaylistSelectionSettings();
            public FaceCullingMode FaceCullingMode { get; set; } = FaceCullingMode.Back;
            public bool EnableMirrorS { get; set; } = false;
            public bool EnableMirrorT { get; set; } = false;
            public bool EnableClampS { get; set; } = false;
            public bool EnableClampT { get; set; } = false;
            public bool EnableCrystalEffect { get; set; } = false;
        }

        private class FinalVertexData
        {
            public byte[] Data { get; set; } = new byte[16];
            public bool EnableVertexColor { get; set; } = false;

            public bool EnableVertexTransparent
            {
                get
                {
                    byte db = Data.LastOrDefault();
                    return db < 0xFF;
                }
            }
        }

        private class FvGroup
        {
            public short NumTri { get; set; } = 0;

            public sbyte[] indexList = new sbyte[2049];

            public List<FinalVertexData> FinalVertexData { get; private set; } = new List<FinalVertexData>();

            public short VertexDataCount
            {
                get
                {
                    return Conversions.ToShort(FinalVertexData.Count);
                }
            }

            public bool EnableVertexColors
            {
                get
                {
                    foreach (FinalVertexData fvd in FinalVertexData)
                    {
                        if (fvd.EnableVertexColor)
                            return true;
                    }

                    return false;
                }
            }

            public bool EnableVertexAlpha
            {
                get
                {
                    foreach (FinalVertexData fvd in FinalVertexData)
                    {
                        if (fvd.EnableVertexTransparent)
                            return true;
                    }

                    return false;
                }
            }
        }

        private class F3D
        {
            public byte[] data = new byte[8];
        }

        private class VertexGroupList
        {
            public int Position { get; set; } = 0;
            public int Length { get; set; } = 0;
            public Material Material { get; set; } = null;

            public int GroupsCount
            {
                get
                {
                    return FinalVertexGroups.Count;
                }
            }

            public int StartIndex { get; set; } = 0;
            public List<FvGroup> FinalVertexGroups { get; private set; } = new List<FvGroup>();

            public bool EnableVertexColors
            {
                get
                {
                    foreach (FvGroup fvg in FinalVertexGroups)
                    {
                        foreach (FinalVertexData fvd in fvg.FinalVertexData)
                        {
                            if (fvd.EnableVertexColor)
                                return true;
                        }
                    }

                    return false;
                }
            }

            public bool EnableVertexAlpha
            {
                get
                {
                    if (!EnableVertexColors)
                        return false;
                    foreach (FvGroup fvg in FinalVertexGroups)
                    {
                        foreach (FinalVertexData fvd in fvg.FinalVertexData)
                        {
                            if (fvd.EnableVertexColor)
                            {
                                if (fvd.Data.LastOrDefault() < 0xFF)
                                    return true;
                            }
                        }
                    }

                    return false;
                }
            }
        }

        private class TextureEntry
        {
            public uint Width { get; set; } = 0;
            public uint Height { get; set; } = 0;
            public byte[] Data { get; set; } = Array.Empty<byte>();
            public byte[] Palette { get; set; } = Array.Empty<byte>();
            public Image OriginalImage { get; set; } = null;
        }

        private class ObjPtrs
        {
            public string name = Conversions.ToString(0);
            public uint start_ptr = 0;
            public uint import_lenght = 0;
            public uint solid_ptr = 0;
            public uint alpha_ptr = 0;
            public uint trans_ptr = 0;
            public uint geo_ptr = 0;
            public uint col_ptr = 0;
            public uint vertex_start = 0;
        }

        public struct ScrollTex
        {
            public int Offset { get; set; }
            public int VertsCount { get; set; }
            public int MaterialAddress { get; set; }
            public string MaterialName { get; set; }

            public ScrollTex(int offset, byte faceCount, int matAddr, string matName)
            {
                Offset = offset;
                VertsCount = faceCount;
                MaterialAddress = matAddr;
                MaterialName = matName;
            }
        }

        private List<Vertex> verts = new List<Vertex>();
        private List<Normal> norms = new List<Normal>();
        private List<VertexColor> vertexColors = new List<VertexColor>();
        private List<TexCord> uvs = new List<TexCord>();
        private List<Material> materials = new List<Material>();
        private List<VertexGroupList> vertexGroups = new List<VertexGroupList>();
        private List<FinalVertexData> finalVertData = new List<FinalVertexData>();
        private List<TextureEntry> textureBank = new List<TextureEntry>();
        private List<ScrollTex> scrollTexts = new List<ScrollTex>();
        private Material currentMaterial;
        private int currentFace = 0;
        private const byte GEOLAYER_SOLID = 1;
        private const byte GEOLAYER_ALPHA = 4;
        private const byte GEOLAYER_TRANSPARENT = 5;
        private byte curSeg = 0;
        private uint startSegOffset = 0;
        private byte[] defaultColor = new byte[24];
        private ConvertSettings settings = null;
        private BinaryData impdata = null;
        private ConvertResult conRes = new ConvertResult();
        private readonly byte[] ColtypesWithParams = new byte[] { 14, 44, 36, 37, 39, 45 };

        private uint CurSegAddress
        {
            get
            {
                return Conversions.ToUInteger(curSeg) << 24;
            }
        }

        private long TXL2WORDS(uint txls, int b_txl)
        {
            return Math.Max(1, txls * b_txl / 8);
        }

        private int CALC_DXT(uint width, int b_txl)
        {
            return (1 << 11) / (int)TXL2WORDS(width, b_txl);
        }

        private uint TXL2WORDS_4b(uint txls)
        {
            return Math.Max(1, txls / 16);
        }

        private uint CALC_DXT_4b(uint width)
        {
            return (1 << 11) / TXL2WORDS_4b(width);
        }

        private void SetLightAndDarkValues(Pilz.S3DFileParser.Shading s)
        {
            // Ambient light color
            defaultColor[0] = s.AmbientColor.R;
            defaultColor[1] = s.AmbientColor.G;
            defaultColor[2] = s.AmbientColor.B;
            defaultColor[3] = 0;
            defaultColor[4] = s.AmbientColor.R;
            defaultColor[5] = s.AmbientColor.G;
            defaultColor[6] = s.AmbientColor.B;
            defaultColor[7] = 0;

            // Diffuse light color
            defaultColor[8] = s.DiffuseColor.R;
            defaultColor[9] = s.DiffuseColor.G;
            defaultColor[10] = s.DiffuseColor.B;
            defaultColor[11] = 0;
            defaultColor[12] = s.DiffuseColor.R;
            defaultColor[13] = s.DiffuseColor.G;
            defaultColor[14] = s.DiffuseColor.B;
            defaultColor[15] = 0;

            // Diffuse light direction
            if (s.DiffusePosition is object)
            {
                float d = (float)(127 / Math.Sqrt(s.DiffusePosition.X * s.DiffusePosition.X + s.DiffusePosition.Y * s.DiffusePosition.Y + s.DiffusePosition.Z * s.DiffusePosition.Z));

                if (float.IsInfinity(d))
                    d = 0;
                defaultColor[16] = Conversions.ToByte(Math.Round(s.DiffusePosition.X * d));
                defaultColor[17] = Conversions.ToByte(Math.Round(s.DiffusePosition.Y * d));
                defaultColor[18] = Conversions.ToByte(Math.Round(s.DiffusePosition.Z * d));
            }
            else
            {
                defaultColor[16] = 0x49; // = Most SM64E Like ||| Default by Nintendo: &H28
                defaultColor[17] = 0x49;
                defaultColor[18] = 0x49;
            }

            defaultColor[19] = 0;
            defaultColor[20] = 0;
            defaultColor[21] = 0;
            defaultColor[22] = 0;
            defaultColor[23] = 0;
        }

        private void ResetVariables()
        {
            vertexGroups.Clear();
            verts.Clear();
            norms.Clear();
            vertexColors.Clear();
            uvs.Clear();
            materials.Clear();
            finalVertData.Clear();
            currentFace = 0;
        }

        private void CheckGeoModeInfo(Material m)
        {
            m.GeoMode = 0;
            var gma = settings.GeoModeData.Split(',');
            foreach (string gme in gma)
            {
                var gmd = gme.Split(':');
                if (m.Name.Equals(gmd[0]))
                {
                    m.GeoMode = Conversions.ToUInteger(gmd[1]);
                    m.EnableGeoMode = true;
                    return;
                }
            }
        }

        private void CheckColorTexInfo(Material m)
        {
            m.Color = 0;
            var gma = settings.ColorTexData.Split(',');
            foreach (string gme in gma)
            {
                var gmd = gme.Split(':');
                if (m.Name.Equals(gmd[0]))
                {
                    m.Color = Conversions.ToUInteger(gmd[1]);
                    m.EnableTextureColor = true;
                    return;
                }
            }
        }

        private void processMaterialColor(string str, Material mat)
        {
            var splitColor = str.Replace(".", ",").Split(' ');
            uint r = (uint)(Convert.ToSingle(splitColor[0]) * 255);
            uint g = (uint)(Convert.ToSingle(splitColor[1]) * 255);
            uint b = (uint)(Convert.ToSingle(splitColor[2]) * 255);
            mat.Color = Conversions.ToUInteger(r << 24 | g << 16 | b << 8 | (long)0xFF);
        }

        private void processMaterialColorAlpha(float alpha, Material mat)
        {
            mat.Color = mat.Color & 0xFFFFFF00U;
            mat.Color = mat.Color | Conversions.ToByte(Conversions.ToLong(0xFF * alpha) & 0xFF);
            if (alpha < 1.0F)
            {
                mat.Type = MaterialType.ColorTransparent;
                mat.HasTransparency = true;
            }
            else if (!mat.HasTexture)
            {
                mat.Type = MaterialType.ColorSolid;
            }
        }

        private void checkN64CodecInfo(Material m)
        {
            var gma = settings.TexTypeData.Split(',');
            foreach (string gme in gma)
            {
                var gmd = gme.Split(':');
                if (m.Name.Equals(gmd[0]))
                {
                    var switchExpr = gmd[1];
                    switch (switchExpr)
                    {
                        case "rgba16":
                            {
                                m.TexType = N64Codec.RGBA16;
                                break;
                            }

                        case "rgba32":
                            {
                                m.TexType = N64Codec.RGBA32;
                                break;
                            }

                        case "ia4":
                            {
                                m.TexType = N64Codec.IA4;
                                break;
                            }

                        case "ia8":
                            {
                                m.TexType = N64Codec.IA8;
                                break;
                            }

                        case "ia16":
                            {
                                m.TexType = N64Codec.IA16;
                                break;
                            }

                        case "i4":
                            {
                                m.TexType = N64Codec.I4;
                                if (gmd.Count() > 2 && (gmd[2] ?? "") == "a")
                                    m.EnableAlphaMask = true;
                                break;
                            }

                        case "i8":
                            {
                                m.TexType = N64Codec.I8;
                                if (gmd.Count() > 2 && (gmd[2] ?? "") == "a")
                                    m.EnableAlphaMask = true;
                                break;
                            }
                    }

                    return;
                }
            }

            m.TexType = N64Codec.RGBA16;
        }

        private Material[] GetDuplicates(Material mat)
        {
            var foundCopies = new List<Material>();
            if (mat.HasTexture)
            {
                foreach (Material checkMat in materials)
                {
                    if (checkMat != mat)
                    {
                        if (checkMat.HasTexture)
                        {
                            if (mat.TexType == checkMat.TexType && General.CompareTwoByteArrays(mat.Texture.Data, checkMat.Texture.Data))
                            {
                                if (!foundCopies.Contains(checkMat))
                                {
                                    foundCopies.Add(checkMat);
                                }
                            }
                        }
                    }
                }
            }

            // For Each copyMat As Material In foundCopies
            // copyMat.texture = mat.texture
            // copyMat.offset = mat.offset
            // copyMat.texWidth = mat.texWidth
            // copyMat.texHeight = mat.texHeight
            // copyMat.size = 0
            // copyMat.isTextureCopy = True
            // Next

            return foundCopies.ToArray();
        }

        private void MergeDuplicatedTextures()
        {
            var matsToRemove = new List<Material>();
            foreach (Material mat in materials)
            {
                if (!matsToRemove.Contains(mat))
                {
                    foreach (Material dup in GetDuplicates(mat))
                    {
                        if (!matsToRemove.Contains(dup))
                        {
                            matsToRemove.Add(dup);
                            foreach (VertexGroupList mp in vertexGroups)
                            {
                                if (mp.Material == dup)
                                {
                                    mp.Material = mat;
                                }
                            }
                        }
                    }
                }
            }

            foreach (Material mat in matsToRemove)
            {
                if (mat.HasTexture && textureBank.Contains(mat.Texture))
                {
                    textureBank.Remove(mat.Texture);
                }

                materials.Remove(mat);
            }
        }

        private void ProcessImage(Pilz.S3DFileParser.Object3D obj, Image img, Material mat)
        {
            TextureEntry entry = null;
            foreach (TextureEntry tex in textureBank)
            {
                if (tex.OriginalImage == img)
                {
                    entry = tex;
                }
            }

            // Create & Add texture entry
            if (entry is null)
            {
                entry = new TextureEntry()
                {
                    Width = mat.TexWidth,
                    Height = mat.TexHeight,
                    OriginalImage = img
                };
            }

            // Load Texture from File
            var bmp = new Bitmap(img);

            // Set texture size
            mat.TexWidth = Conversions.ToUInteger(bmp.Width);
            mat.TexHeight = Conversions.ToUInteger(bmp.Height);

            // Convert texture
            var argimageData = entry.Data;
            var argpaletteData = entry.Palette;
            N64Graphics.N64Graphics.Convert(ref argimageData, ref argpaletteData, mat.TexType, (Bitmap)img);
            entry.Data = argimageData;
            entry.Palette = argpaletteData;

            // Get Texture like it is ingame (fixes bug that sometimes transparency is there even if there isn't)
            if (settings.OptimizeTransparencyChecks)
            {
                bmp = new Bitmap(bmp.Width, bmp.Height);
                var g = Graphics.FromImage(bmp);
                N64Graphics.N64Graphics.RenderTexture(g, entry.Data, entry.Palette, 0, Conversions.ToInteger(mat.TexWidth), Conversions.ToInteger(mat.TexHeight), 1, mat.TexType, N64IMode.AlphaCopyIntensity);
            }

            mat.Type = MaterialType.TextureSolid;

            // Check for alpha and transparency
            for (int y = 0, loopTo = bmp.Height - 1; y <= loopTo; y++)
            {
                for (int x = 0, loopTo1 = bmp.Width - 1; x <= loopTo1; x++)
                {
                    var pix = bmp.GetPixel(x, y);
                    var switchExpr = mat.TexType;
                    switch (switchExpr)
                    {
                        case N64Codec.RGBA16:
                        case N64Codec.RGBA32:
                        case N64Codec.IA4:
                        case N64Codec.IA8:
                        case N64Codec.IA16:
                        case N64Codec.CI4:
                        case N64Codec.CI8:
                            {
                                if (pix.A == 0 && !mat.HasTransparency)
                                {
                                    mat.HasTextureAlpha = true;
                                    mat.Type = MaterialType.TextureAlpha;
                                }
                                else if (pix.A < 0xFF)
                                {
                                    mat.Type = MaterialType.TextureTransparent;
                                    mat.HasTransparency = true;
                                }

                                break;
                            }

                        // If pix.A = 0 Then
                        // mat.hasTextureAlpha = True
                        // mat.type = MaterialType.TextureAlpha
                        // mat.HasTransparency = False
                        // ElseIf pix.A < &HFF OrElse mat.opacity < &HFF Then
                        // If mat.Type <> MaterialType.TextureAlpha Then
                        // If mat.Opacity = &HFF Then
                        // mat.Opacity = (CInt(mat.Opacity) * pix.A) And &HFF
                        // End If
                        // mat.Type = MaterialType.TextureTransparent
                        // mat.HasTransparency = True
                        // End If
                        // End If

                        case N64Codec.I4:
                        case N64Codec.I8:
                            {
                                if (pix.A < 0xFF || mat.EnableAlphaMask)
                                {
                                    mat.Type = MaterialType.TextureTransparent;
                                    mat.HasTransparency = true;
                                }

                                break;
                            }
                    }
                }
            }

            if (!textureBank.Contains(entry))
                textureBank.Add(entry);
            mat.Texture = entry;
            mat.HasTexture = true;
            mat.HasPalette = entry.Palette.Any();
        }

        private void ProcessObject3DModel(Pilz.S3DFileParser.Object3D obj)
        {
            var texFormatSettings = settings.TextureFormatSettings;

            // Process Materials
            ProcessObject3DMaterials(obj, texFormatSettings);
            foreach (Pilz.S3DFileParser.Mesh mesh in obj.Meshes)
            {
                int curIndexStart = verts.Count;

                // Process Vertices
                foreach (var vert in mesh.Vertices)
                {
                    var v = new Vertex()
                    {
                        X = General.KeepInInt16Range(General.Round(vert.X * settings.Scale + settings.OffsetPosition.X)),
                        Y = General.KeepInInt16Range(General.Round(vert.Y * settings.Scale + settings.OffsetPosition.Y)),
                        Z = General.KeepInInt16Range(General.Round(vert.Z * settings.Scale + settings.OffsetPosition.Z))
                    };
                    verts.Add(v);
                }

                // Process Normals
                foreach (var norm in mesh.Normals)
                {
                    var n = new Normal()
                    {
                        A = Datatypecastes.LongToByte(Conversions.ToLong(General.Round(norm.X * 0x7F))),
                        B = Datatypecastes.LongToByte(Conversions.ToLong(General.Round(norm.Y * 0x7F))),
                        C = Datatypecastes.LongToByte(Conversions.ToLong(General.Round(norm.Z * 0x7F))),
                        D = 0xFF
                    };
                    norms.Add(n);
                }

                // Process UVs
                foreach (Pilz.S3DFileParser.UV tuv in mesh.UVs)
                {
                    var uv = new TexCord()
                    {
                        U = Conversions.ToSingle(General.Round(tuv.U * 32 * 32)),
                        V = Conversions.ToSingle(General.Round(-(tuv.V * 32 * 32)))
                    };
                    uvs.Add(uv);
                }

                // Process Vertex Colors
                foreach (var vertcol in mesh.VertexColors)
                {
                    var vc = new VertexColor()
                    {
                        R = Datatypecastes.LongToByte(Conversions.ToLong(General.Round(vertcol.R * 0xFF))),
                        G = Datatypecastes.LongToByte(Conversions.ToLong(General.Round(vertcol.G * 0xFF))),
                        B = Datatypecastes.LongToByte(Conversions.ToLong(General.Round(vertcol.B * 0xFF))),
                        A = Datatypecastes.LongToByte(Conversions.ToLong(General.Round(vertcol.A * 0xFF)))
                    };
                    vertexColors.Add(vc);
                }

                // Process Faces
                object curTexture = null;
                foreach (var face in mesh.Faces) // .OrderBy(Function(n) n.Texture)
                {
                    if (curTexture is null || !curTexture.Equals(face.Material))
                    {
                        curTexture = face.Material;
                        string curMatName = obj.Materials.FirstOrDefault(n => n.Value.Equals(face.Material)).Key;
                        var curMat = materials.FirstOrDefault(n => n.Name.Equals(curMatName));
                        var mp = new VertexGroupList()
                        {
                            Position = currentFace,
                            Material = curMat
                        };
                        currentMaterial = curMat;
                        mp.Length = 0;
                        vertexGroups.Add(mp);
                    }

                    Material mat = null;
                    int indexOfMat = 0;
                    while (mat is null && obj.Materials.Count > indexOfMat)
                    {
                        if (obj.Materials.ElementAt(indexOfMat).Value.Equals(face.Material) && materials[indexOfMat] is object)
                        {
                            mat = materials[indexOfMat];
                        }
                        else
                        {
                            indexOfMat += 1;
                        }
                    }

                    Vertex va = null;
                    TexCord ta = null;
                    var tanew = new TexCord();
                    Normal na = null;
                    VertexColor vca = null;
                    Vertex vb = null;
                    TexCord tb = null;
                    var tbnew = new TexCord();
                    Normal nb = null;
                    VertexColor vcb = null;
                    Vertex vc = null;
                    TexCord tc = null;
                    var tcnew = new TexCord();
                    Normal nc = null;
                    VertexColor vcc = null;
                    void getVals(Pilz.S3DFileParser.Point point, ref Vertex vert, ref TexCord t, ref Normal normal, ref VertexColor vertcol)
                    {
                        if (point.Vertex is object)
                            vert = verts[curIndexStart + mesh.Vertices.IndexOf(point.Vertex)];
                        if (point.UV is object)
                            t = uvs[curIndexStart + mesh.UVs.IndexOf(point.UV)];
                        if (point.Normal is object)
                            normal = norms[curIndexStart + mesh.Normals.IndexOf(point.Normal)];
                        if (point.VertexColor is object)
                            vertcol = vertexColors[curIndexStart + mesh.VertexColors.IndexOf(point.VertexColor)];
                    };
                    getVals(face.Points[0], ref va, ref ta, ref na, ref vca);
                    getVals(face.Points[1], ref vb, ref tb, ref nb, ref vcb);
                    getVals(face.Points[2], ref vc, ref tc, ref nc, ref vcc);
                    var fa = new FinalVertexData();
                    var fb = new FinalVertexData();
                    var fc = new FinalVertexData();

                    // Modify UV cordinates based on material.
                    void modifyUVCordinates(TexCord tnew, TexCord t)
                    {
                        tnew.U = (float)(t.U * (mat.TexWidth / 32.0) - 16); // "-16" fixes the UVs offset
                        tnew.V = (float)(t.V * (mat.TexHeight / 32.0) - 16); // "-16" fixes the UVs offset
                    };
                    modifyUVCordinates(tanew, ta);
                    modifyUVCordinates(tbnew, tb);
                    modifyUVCordinates(tcnew, tc);

                    // Fix UVs to reduce number of (large) faces with broken textures
                    FixUVs(tanew, tbnew, tcnew, Conversions.ToInteger(mat.TexWidth), Conversions.ToInteger(mat.TexHeight));

                    // Vertex Structure: xxxxyyyyzzzz0000uuuuvvvvrrggbbaa
                    void buildVertexStructure(FinalVertexData final, Vertex vert, VertexColor vertcol, TexCord tnew, Normal normal)
                    {
                        final.Data[0] = Conversions.ToByte(vert.X >> 8 & 0xFF);
                        final.Data[1] = Conversions.ToByte(vert.X & 0xFF);
                        final.Data[2] = Conversions.ToByte(vert.Y >> 8 & 0xFF);
                        final.Data[3] = Conversions.ToByte(vert.Y & 0xFF);
                        final.Data[4] = Conversions.ToByte(vert.Z >> 8 & 0xFF);
                        final.Data[5] = Conversions.ToByte(vert.Z & 0xFF);
                        final.Data[6] = 0;
                        final.Data[7] = 0;
                        int uInt, vInt;
                        uInt = Conversions.ToInteger(Math.Round(tnew.U));
                        vInt = Conversions.ToInteger(Math.Round(tnew.V));
                        final.Data[8] = Conversions.ToByte(uInt >> 8 & 0xFF);
                        final.Data[9] = Conversions.ToByte(uInt & 0xFF);
                        final.Data[10] = Conversions.ToByte(vInt >> 8 & 0xFF);
                        final.Data[11] = Conversions.ToByte(vInt & 0xFF);
                        if (vertcol is object)
                        {
                            final.Data[12] = vertcol.R;
                            final.Data[13] = vertcol.G;
                            final.Data[14] = vertcol.B;
                            final.Data[15] = vertcol.A;
                            final.EnableVertexColor = true;
                            // FIXME: Add warning if Type is not TextureSolid
                            if (final.EnableVertexTransparent)
                            {
                                mat.Type = MaterialType.TextureTransparent;
                                mat.HasTransparency = mat.HasTransparency || final.EnableVertexTransparent;
                            }
                        }
                        else
                        {
                            final.Data[12] = normal.A;
                            final.Data[13] = normal.B;
                            final.Data[14] = normal.C;
                            final.Data[15] = normal.D;
                            final.EnableVertexColor = false;
                        }
                    };
                    buildVertexStructure(fa, va, vca, tanew, na);
                    buildVertexStructure(fb, vb, vcb, tbnew, nb);
                    buildVertexStructure(fc, vc, vcc, tcnew, nc);
                    finalVertData.AddRange(new[] { fa, fb, fc });
                    currentFace += 1;
                }
            }
        }

        private void ProcessObject3DMaterials(Pilz.S3DFileParser.Object3D obj, TextureFormatSettings texFormatSettings)
        {
            var tasks = new List<Task>();

            // Start converting each image
            foreach (var kvp in obj.Materials)
                // Dim t As New Task(Sub() ProcessObject3DMaterial(obj, kvp, texFormatSettings))
                // t.Start()
                // tasks.Add(t)
                ProcessObject3DMaterial(obj, kvp, texFormatSettings);

            // Wait until all images has been converted
            // For Each t As Task In tasks
            // t.Wait()
            // Next
        }

        private void ProcessObject3DMaterial(Pilz.S3DFileParser.Object3D obj, KeyValuePair<string, Pilz.S3DFileParser.Material> kvp, TextureFormatSettings texFormatSettings)
        {
            int size = 0;
            var curEntry = texFormatSettings.GetEntry(kvp.Key);

            // Create new Material
            var m = new Material()
            {
                Type = MaterialType.ColorSolid,
                Color = 0,
                HasTexture = false,
                HasTextureAlpha = false,
                HasTransparency = false,
                Name = kvp.Key,
                Collision = 0,
                Opacity = 0xFF,
                OpacityOrg = 0xFF,
                EnableGeoMode = false,
                EnableTextureColor = false,
                EnableAlphaMask = false,
                CameFromBMP = false,
                EnableScrolling = curEntry.IsScrollingTexture,
                DisplaylistSelection = curEntry.DisplaylistSelection,
                EnableMirrorS = curEntry.EnableMirrorS,
                EnableMirrorT = curEntry.EnableMirrorT,
                EnableClampS = curEntry.EnableClampS,
                EnableClampT = curEntry.EnableClampT,
                EnableCrystalEffect = curEntry.EnableCrystalEffect
            };

            // Set default size
            size = 0x10;

            // Check some things
            CheckGeoModeInfo(m);
            CheckColorTexInfo(m);

            // Add material
            materials.Add(m);

            // Process Material Color
            if (!m.EnableTextureColor)
            {
                uint r = kvp.Value.Color.Value.R;
                uint g = kvp.Value.Color.Value.G;
                uint b = kvp.Value.Color.Value.B;
                uint a = kvp.Value.Color.Value.A;
                m.Color = r << 24 | g << 16 | b << 8 | a;
                if (a == (long)0xFF)
                {
                    m.Type = MaterialType.ColorSolid;
                }
                else
                {
                    m.Type = MaterialType.ColorTransparent;
                }
            }

            // Check Texture Type
            if (texFormatSettings is object)
            {
                m.TexType = N64Graphics.N64Graphics.StringCodec(texFormatSettings.GetEntry(kvp.Key).TextureFormat);
            }

            // Process Material Image
            if (kvp.Value.Image is object)
            {
                ProcessImage(obj, kvp.Value.Image, m);
                size = m.Texture.Data.Length;
            }

            // Process Material Color Alpha
            if (kvp.Value.Opacity is object)
            {
                float tempopacity = (float)kvp.Value.Opacity;
                m.Opacity = Conversions.ToByte(Conversions.ToLong(tempopacity * 0xFF) & 0xFF);
                m.OpacityOrg = m.Opacity;
                processMaterialColorAlpha(tempopacity, m);
            }

            // Set offset and size
            m.Size = Conversions.ToUInteger(size);
            if (m.Texture?.Palette is object)
            {
                m.PaletteSize = Conversions.ToUInteger(m.Texture.Palette.Length);
            }
        }

        private void FixUVs(TexCord uv1, TexCord uv2, TexCord uv3, int matWidth, int matHeight)
        {
            if (matWidth <= 0 || matHeight <= 0) return;

            TexCord[] uvs = null;
            int jump = 0;

            jump = matWidth * 0x40;
            uvs = new[] { uv1, uv2, uv3 }.OrderBy(n => n.U).ToArray();

            if (jump != 0)
            {
                while (uvs.Last().U > 32767)
                {
                    uvs[0].U -= jump;
                    uvs[1].U -= jump;
                    uvs[2].U -= jump;
                }

                while (uvs.First().U < -32768)
                {
                    uvs[0].U += jump;
                    uvs[1].U += jump;
                    uvs[2].U += jump;
                }
            }

            jump = matHeight * 0x40;
            uvs = new[] { uv1, uv2, uv3 }.OrderBy(n => n.V).ToArray();

            if (jump != 0)
            {
                while (uvs.Last().V > 32767)
                {
                    uvs[0].V -= jump;
                    uvs[1].V -= jump;
                    uvs[2].V -= jump;
                }

                while (uvs.First().V < -32768)
                {
                    uvs[0].V += jump;
                    uvs[1].V += jump;
                    uvs[2].V += jump;
                }
            }
        }

        private void removeDuplicateVertices(ReduceVericesLevel level)
        {
            if ((int)level < 1) return;

            int dupCnt = 0;

            foreach (VertexGroupList mp in vertexGroups)
            {
                for (int g = 0, loopTo = mp.GroupsCount - 1; g <= loopTo; g++)
                {
                    var fvg = mp.FinalVertexGroups[g];
                    if (fvg.VertexDataCount < 1)
                        continue;
                    for (int i = 0, loopTo1 = fvg.VertexDataCount - 1; i <= loopTo1; i++)
                    {
                        int j = i + 1;
                        while (j < fvg.VertexDataCount)
                        {
                            if (General.CompareTwoByteArrays(fvg.FinalVertexData[i].Data, fvg.FinalVertexData[j].Data, 16))
                            {
                                moveElementsInGroupUpward(fvg, 1, j);
                                UpdateIndexList(fvg, Conversions.ToByte(j), Conversions.ToByte(i));
                                UpdatePositions(mp.StartIndex);
                                dupCnt += 1;
                            }

                            j += 1;
                        }
                    }

                    if (g < mp.GroupsCount - 1 && (int)level > 1)
                    {
                        if (MoveVertsBack(mp.FinalVertexGroups[g], mp.FinalVertexGroups[g + 1]))
                        {
                            g -= 1;
                        }
                    }
                }
            }
        }

        private void UpdateIndexList(FvGroup grp, byte removed, byte replaceWith)
        {
            for (int i = 0, loopTo = grp.NumTri * 3 - 1; i <= loopTo; i++)
            {
                if (grp.indexList[i] < removed)
                    continue;
                if (grp.indexList[i] == removed)
                {
                    grp.indexList[i] = Conversions.ToSByte(replaceWith);
                }
                else
                {
                    grp.indexList[i] -= 1;
                }
            }
        }

        private void UpdatePositions(int vs)
        {
            foreach (VertexGroupList mp in vertexGroups)
            {
                if (mp.StartIndex <= vs)
                    continue;
                if (mp.StartIndex < 0x10)
                    continue;
                mp.StartIndex -= 0x10;
            }
        }

        private bool MoveVertsBack(FvGroup to, FvGroup from)
        {
            if (from.VertexDataCount < 3)
                return false;
            if (to.VertexDataCount < 14)
            {
                to.FinalVertexData.Add(from.FinalVertexData[0]);
                to.FinalVertexData.Add(from.FinalVertexData[1]);
                to.FinalVertexData.Add(from.FinalVertexData[2]);
                to.indexList[to.NumTri * 3] = Conversions.ToSByte(to.VertexDataCount);
                to.indexList[to.NumTri * 3 + 1] = Conversions.ToSByte(to.VertexDataCount + 1);
                to.indexList[to.NumTri * 3 + 2] = Conversions.ToSByte(to.VertexDataCount + 2);
                moveElementsInGroupUpward(from, 3, 0);
                to.NumTri += 1;
                return true;
            }

            return false;
        }

        private void moveElementsInGroupUpward(FvGroup grp, int amount, int start)
        {
            for (int i = 0, loopTo = amount - 1; i <= loopTo; i++)
                grp.FinalVertexData.RemoveAt(start);
        }

        private void BuildVertexGroups()
        {
            int vs = 0;
            for (int i = 0, loopTo = vertexGroups.Count - 1; i <= loopTo; i++)
            {
                {
                    var withBlock = vertexGroups[i];
                    withBlock.StartIndex = vs;
                    int length = 0;
                    if (i < vertexGroups.Count - 1)
                    {
                        length = vertexGroups[i + 1].Position - withBlock.Position;
                    }
                    else
                    {
                        length = currentFace - withBlock.Position;
                    }

                    int groupsCount = 0;
                    if (length % 5 == 0)
                    {
                        groupsCount = (int)(length / (double)5);
                    }
                    else
                    {
                        groupsCount = (int)(Math.Truncate(length / (double)5) + 1);
                    }

                    for (int j = 0, loopTo1 = groupsCount - 1; j <= loopTo1; j++)
                        withBlock.FinalVertexGroups.Add(new FvGroup() { NumTri = 0 });
                    for (int g = 0, loopTo2 = groupsCount - 1; g <= loopTo2; g++)
                    {
                        int s = 5;
                        if (g == groupsCount - 1)
                            s = length % 5;
                        if (s == 0)
                            s = 5;
                        var curFvg = withBlock.FinalVertexGroups[g];
                        curFvg.NumTri = Conversions.ToShort(s);
                        for (int j = 0, loopTo3 = s - 1; j <= loopTo3; j++)
                        {
                            int from = (withBlock.Position + j + g * 5) * 3;
                            curFvg.FinalVertexData.Add(finalVertData[from]);
                            curFvg.FinalVertexData.Add(finalVertData[from + 1]);
                            curFvg.FinalVertexData.Add(finalVertData[from + 2]);
                            curFvg.indexList[j * 3] = Conversions.ToSByte(j * 3);
                            curFvg.indexList[j * 3 + 1] = Conversions.ToSByte(j * 3 + 1);
                            curFvg.indexList[j * 3 + 2] = Conversions.ToSByte(j * 3 + 2);
                        }

                        vs += curFvg.VertexDataCount * 0x10;
                    }
                }
            }
        }

        private F3D StrToF3D(string str)
        {
            var cmd = new F3D();
            var b = str.Replace(".", ",").Split(' ');
            for (int i = 0, loopTo = b.Count() - 1; i <= loopTo; i++)
                cmd.data[i] = Conversions.ToByte($"&H{b[i]}");
            return cmd;
        }

        private void ImpF3D(string str)
        {
            ImpF3D(StrToF3D(str));
        }

        private void ImpF3D(F3D f3d)
        {
            impdata.Write(f3d.data);
        }

        private byte[] GetColorData(Material mt, ref float darkMult)
        {
            var colorData = new byte[24];
            byte lr, lg, lb, a;
            ushort dr, dg, db;
            lr = Conversions.ToByte(mt.Color >> 24 & (long)0xFF);
            lg = Conversions.ToByte(mt.Color >> 16 & (long)0xFF);
            lb = Conversions.ToByte(mt.Color >> 8 & (long)0xFF);
            dr = Conversions.ToUShort(lr * darkMult);
            dg = Conversions.ToUShort(lg * darkMult);
            db = Conversions.ToUShort(lb * darkMult);
            if (dr > 0xFF)
                dr = 0xFF;
            if (dg > 0xFF)
                dg = 0xFF;
            if (db > 0xFF)
                db = 0xFF;
            a = Conversions.ToByte(mt.Color & (long)0xFF);
            colorData[0] = lr;
            colorData[1] = lg;
            colorData[2] = lb;
            colorData[3] = 0;
            colorData[4] = lr;
            colorData[5] = lg;
            colorData[6] = lb;
            colorData[7] = 0;
            colorData[8] = Conversions.ToByte(dr);
            colorData[9] = Conversions.ToByte(dg);
            colorData[10] = Conversions.ToByte(db);
            colorData[11] = 0;
            colorData[12] = Conversions.ToByte(dr);
            colorData[13] = Conversions.ToByte(dg);
            colorData[14] = Conversions.ToByte(db);
            colorData[15] = 0;
            for (int i = 16, loopTo = colorData.Length - 1; i <= loopTo; i++)
                colorData[i] = defaultColor[i];
            return colorData;
        }

        private void ImpFogStart(int layer)
        {
            ImpF3D("BA 00 14 02 00 10 00 00");
            string cmdF8 = "";
            cmdF8 = $"F8 00 00 00 {Microsoft.VisualBasic.Conversion.Hex(settings.Fog.Color.R)} {Microsoft.VisualBasic.Conversion.Hex(settings.Fog.Color.G)} {Microsoft.VisualBasic.Conversion.Hex(settings.Fog.Color.B)} FF";
            ImpF3D(cmdF8);
            switch (layer)
            {
                case 0:
                    {
                        ImpF3D("B9 00 03 1D C8 11 22 30");
                        break;
                    }

                case 1:
                    {
                        ImpF3D("B9 00 03 1D C8 11 20 78");
                        break;
                    }

                case 2:
                    {
                        ImpF3D("B9 00 03 1D C8 11 2D 58");
                        break;
                    }

                case 3:
                    {
                        ImpF3D("B9 00 03 1D C8 10 4D D8");
                        break;
                    }
                // ImpF3D("B9 00 03 1D 00 11 24 78")
                case 4:
                    {
                        ImpF3D("B9 00 03 1D C8 11 30 78");
                        break;
                    }

                case 5:
                    {
                        ImpF3D("B9 00 03 1D C8 10 49 D8");
                        break;
                    }

                case 6:
                    {
                        ImpF3D("B9 00 03 1D C8 10 4D D8");
                        break;
                    }

                case 7:
                    {
                        ImpF3D("B9 00 03 1D C8 10 45 D8");
                        break;
                    }
            }

            var switchExpr = settings.Fog.Type;
            switch (switchExpr)
            {
                case FogPreset.SubtleFog1:
                    {
                        ImpF3D("BC 00 00 08 19 00 E8 00");
                        break;
                    }

                case FogPreset.SubtleFog2:
                    {
                        ImpF3D("BC 00 00 08 12 00 F0 00");
                        break;
                    }

                case FogPreset.ModerateFog1:
                    {
                        ImpF3D("BC 00 00 08 0E 49 F2 B7");
                        break;
                    }

                case FogPreset.ModerateFog2:
                    {
                        ImpF3D("BC 00 00 08 0C 80 F4 80");
                        break;
                    }

                case FogPreset.ModerateFog3:
                    {
                        ImpF3D("BC 00 00 08 0A 00 F7 00");
                        break;
                    }

                case FogPreset.ModerateFog4:
                    {
                        ImpF3D("BC 00 00 08 08 55 F8 AB");
                        break;
                    }

                case FogPreset.IntenseFog:
                    {
                        ImpF3D("BC 00 00 08 07 24 F9 DC");
                        break;
                    }

                case FogPreset.VeryIntenseFog:
                    {
                        ImpF3D("BC 00 00 08 05 00 FC 00");
                        break;
                    }

                case FogPreset.HardcoreFog:
                    {
                        ImpF3D("BC 00 00 08 02 50 FF 00");
                        break;
                    }
            }

            ImpF3D("B7 00 00 00 00 01 00 00");
        }

        private void ImpFogEnd(int layer)
        {
            ImpF3D("BA 00 14 02 00 00 00 00");
            switch (layer)
            {
                case 0:
                    {
                        ImpF3D("B9 00 03 1D 00 44 22 30");
                        break;
                    }

                case 1:
                    {
                        ImpF3D("B9 00 03 1D 00 44 20 78");
                        break;
                    }

                case 2:
                    {
                        ImpF3D("B9 00 03 1D 00 44 2D 58");
                        break;
                    }

                case 3:
                    {
                        ImpF3D("B9 00 03 1D 00 40 4D D8");
                        break;
                    }
                // ImpF3D("B9 00 03 1D 00 44 24 78")
                case 4:
                    {
                        ImpF3D("B9 00 03 1D 00 44 30 78");
                        break;
                    }

                case 5:
                    {
                        ImpF3D("B9 00 03 1D 00 40 49 D8");
                        break;
                    }

                case 6:
                    {
                        ImpF3D("B9 00 03 1D 00 40 4D D8");
                        break;
                    }

                case 7:
                    {
                        ImpF3D("B9 00 03 1D 00 40 45 D8");
                        break;
                    }
            }

            ImpF3D("B6 00 00 00 00 01 00 00"); // B6 00 00 00 00 01 02 00 --> Smoothen Shading?
        }

        private byte GetTypeFromMaterial(Material mat)
        {
            return GetTypeFromTexType(mat.TexType);
        }

        private byte GetTypeFromTexType(N64Codec texType, bool advanced = false)
        {
            switch (texType)
            {
                case N64Codec.CI4:
                    {
                        return Conversions.ToByte(advanced ? 0x50 : 0x40);
                    }

                case N64Codec.CI8:
                    {
                        return Conversions.ToByte(advanced ? 0x50 : 0x48);
                    }

                case N64Codec.I4:
                    {
                        return Conversions.ToByte(advanced ? 0x90 : 0x80);
                    }

                case N64Codec.I8:
                    {
                        return Conversions.ToByte(advanced ? 0x90 : 0x88);
                    }

                case N64Codec.IA4:
                    {
                        return Conversions.ToByte(advanced ? 0x70 : 0x60);
                    }

                case N64Codec.IA8:
                    {
                        return Conversions.ToByte(advanced ? 0x70 : 0x68);
                    }

                case N64Codec.IA16:
                    {
                        return 0x70;
                    }

                case N64Codec.RGBA16:
                    {
                        return 0x10;
                    }

                case N64Codec.RGBA32:
                    {
                        return 0x18;
                    }

                default:
                    {
                        return default;
                    }
            }
        }

        private byte BytesPerType(N64Codec type)
        {
            switch (type)
            {
                case N64Codec.RGBA16:
                    {
                        return 2;
                    }

                case N64Codec.RGBA32:
                    {
                        return 4;
                    }

                case N64Codec.I4:
                case N64Codec.IA4:
                case N64Codec.CI4:
                    {
                        return 0; // Special case
                    }

                case N64Codec.IA8:
                case N64Codec.I8:
                case N64Codec.CI8:
                    {
                        return 1;
                    }

                default:
                    {
                        return 2;
                    }
            }
        }

        private byte GetTexelIncrement(N64Codec type)
        {
            switch (type)
            {
                case N64Codec.I4:
                case N64Codec.IA4:
                    {
                        return 3;
                    }

                case N64Codec.IA8:
                case N64Codec.I8:
                    {
                        return 1;
                    }

                default:
                    {
                        return 0;
                    }
            }
        }

        private byte GetTexelShift(N64Codec type)
        {
            switch (type)
            {
                case N64Codec.I4:
                case N64Codec.IA4:
                case N64Codec.CI4:
                    {
                        return 2;
                    }

                case N64Codec.IA8:
                case N64Codec.I8:
                case N64Codec.CI8:
                    {
                        return 1;
                    }

                default:
                    {
                        return 0;
                    }
            }
        }

        private void ImpCmdFD(uint offset, N64Codec texType)
        {
            uint off = startSegOffset + offset;
            byte type = GetTypeFromTexType(texType, true);
            ImpF3D($"FD {Microsoft.VisualBasic.Conversion.Hex(type)} 00 00 {Microsoft.VisualBasic.Conversion.Hex(curSeg & 0xFF)} {Microsoft.VisualBasic.Conversion.Hex(off >> 16 & (long)0xFF)} {Microsoft.VisualBasic.Conversion.Hex(off >> 8 & (long)0xFF)} {Microsoft.VisualBasic.Conversion.Hex(off & (long)0xFF)}");
        }

        private void ImpCmdF5_First(N64Codec texType)
        {
            byte type = GetTypeFromTexType(texType, true);
            ImpF3D($"F5 {Microsoft.VisualBasic.Conversion.Hex(type)} 00 00 07 00 00 00");
        }

        private void ImpCmdF5_Second(Material mat, uint texWidth, uint texHeight)
        {
            // Create upper
            byte type = GetTypeFromTexType(mat.TexType);
            float lineScale = 1.0F;
            byte bpt = BytesPerType(mat.TexType);
            if (bpt != 0)
            {
                lineScale = (float)(bpt / 4.0);
            }
            else
            {
                lineScale = 0.125F;
            }

            if (mat.TexType == N64Codec.RGBA32)
            {
                lineScale /= 2;
            }

            ushort line = Conversions.ToUShort(Conversions.ToUShort(Math.Truncate(texWidth * lineScale)) & 0x1FF);
            uint upper = Conversions.ToUInteger((Conversions.ToUInteger(type) << 16 | Conversions.ToUInteger(line) << 8) & (long)0xFFFFFF);

            // Create lower (shift)
            byte maskS = Conversions.ToByte(Conversions.ToLong(Math.Ceiling(Math.Log(texWidth, 2))) & 0xF);
            byte maskT = Conversions.ToByte(Conversions.ToLong(Math.Ceiling(Math.Log(texHeight, 2))) & 0xF);
            uint lower = Conversions.ToUInteger((Conversions.ToUInteger(maskT) << 14 | Conversions.ToUInteger(maskS) << 4) & (long)0xFFFFFF); // &HFFC3F0 for only shift
            if (mat.EnableMirrorS)
            {
                lower = Conversions.ToUInteger(lower | (long)0x100);      // S axis
            }

            if (mat.EnableMirrorT)
            {
                lower = Conversions.ToUInteger(lower | (long)0x40000);    // T axis
            }

            if (mat.EnableClampS)
            {
                lower = Conversions.ToUInteger(lower | (long)0x80000);    // T axis
            }

            if (mat.EnableClampT)
            {
                lower = Conversions.ToUInteger(lower | (long)0x200);      // S axis
            }

            // Create Command
            ImpF3D($"F5 {Microsoft.VisualBasic.Conversion.Hex(upper >> 16 & (long)0xFF)} {Microsoft.VisualBasic.Conversion.Hex(upper >> 8 & (long)0xFF)} {Microsoft.VisualBasic.Conversion.Hex(upper & (long)0xFF)} 00 {Microsoft.VisualBasic.Conversion.Hex(lower >> 16 & (long)0xFF)} {Microsoft.VisualBasic.Conversion.Hex(lower >> 8 & (long)0xFF)} {Microsoft.VisualBasic.Conversion.Hex(lower & (long)0xFF)}");
        }

        private void AddCmdF3(Material mat)
        {
            uint numTexels = (uint)((mat.TexWidth * mat.TexHeight + GetTexelIncrement(mat.TexType) >> GetTexelShift(mat.TexType)) - (long)1);
            int bpt = BytesPerType(mat.TexType);
            uint tl;
            uint lower;
            string cmd;
            if (bpt != 0)
            {
                tl = (uint)(CALC_DXT(mat.TexWidth, bpt) & 0xFFF);
            }
            else
            {
                tl = CALC_DXT_4b(mat.TexWidth) & 0xFFF;
            }

            lower = Conversions.ToUInteger((numTexels << 12 | tl) & (long)0xFFFFFF);
            cmd = $"F3 00 00 00 07 {Microsoft.VisualBasic.Conversion.Hex(lower >> 16 & (long)0xFF)} {Microsoft.VisualBasic.Conversion.Hex(lower >> 8 & (long)0xFF)} {Microsoft.VisualBasic.Conversion.Hex(lower & (long)0xFF)}";
            ImpF3D(cmd);
        }

        private void AddCmdF2(Material mat)
        {
            ushort width = Conversions.ToUShort(mat.TexWidth - (long)1 << 2 & 0xFFF);
            ushort height = Conversions.ToUShort(mat.TexHeight - (long)1 << 2 & 0xFFF);
            uint data = Conversions.ToUInteger(Conversions.ToInteger(width) << 12 | height);
            string cmd = $"F2 00 00 00 00 {Microsoft.VisualBasic.Conversion.Hex(data >> 16 & (long)0xFF)} {Microsoft.VisualBasic.Conversion.Hex(data >> 8 & (long)0xFF)} {Microsoft.VisualBasic.Conversion.Hex(data & (long)0xFF)}";
            ImpF3D(cmd);
        }

        private void AddCmdFC(Material mat, ref string lastCmd)
        {
            string cmd = string.Empty;
            var colorFormula = F3D_SETCOMBINE.Formula.Output(F3D_SETCOMBINE.CCMUX.SHADE);
            bool isColorPresent = Conversions.ToDouble(Conversions.ToString(mat.Color) + Conversions.ToString(0xFFFFFF00U)) != 0xFFFFFF00U;
            if (mat.HasTexture)
            {
                var switchExpr = mat.Type;
                switch (switchExpr)
                {
                    case MaterialType.None:
                    case MaterialType.TextureSolid:
                    case MaterialType.TextureAlpha:
                    case MaterialType.TextureTransparent:
                        {
                            colorFormula = F3D_SETCOMBINE.Formula.Multiply(F3D_SETCOMBINE.CCMUX.TEXEL0, F3D_SETCOMBINE.CCMUX.SHADE);
                            break;
                        }

                    case MaterialType.ColorSolid:
                    case MaterialType.ColorTransparent:
                        {
                            if (isColorPresent)
                            {
                                colorFormula = F3D_SETCOMBINE.Formula.Multiply(F3D_SETCOMBINE.CCMUX.TEXEL0, F3D_SETCOMBINE.CCMUX.ENVIRONMENT);
                            }
                            else
                            {
                                // TODO: This condition cannot be met with current setup
                                colorFormula = F3D_SETCOMBINE.Formula.Multiply(F3D_SETCOMBINE.CCMUX.TEXEL0, F3D_SETCOMBINE.CCMUX.SHADE);
                            }

                            break;
                        }
                }
            }
            else
            {
                var switchExpr1 = mat.Type;
                switch (switchExpr1)
                {
                    case MaterialType.None:
                    case MaterialType.TextureSolid:
                    case MaterialType.TextureAlpha:
                    case MaterialType.TextureTransparent:
                        {
                            colorFormula = F3D_SETCOMBINE.Formula.Output(F3D_SETCOMBINE.CCMUX.SHADE);
                            break;
                        }

                    case MaterialType.ColorSolid:
                    case MaterialType.ColorTransparent:
                        {
                            if (isColorPresent)
                            {
                                colorFormula = F3D_SETCOMBINE.Formula.Multiply(F3D_SETCOMBINE.CCMUX.SHADE, F3D_SETCOMBINE.CCMUX.ENVIRONMENT);
                            }
                            else
                            {
                                colorFormula = F3D_SETCOMBINE.Formula.Output(F3D_SETCOMBINE.CCMUX.SHADE);
                            }

                            break;
                        }
                }
            }

            var alphaFormula = F3D_SETCOMBINE.Formula.Output(F3D_SETCOMBINE.ACMUX.SHADE);
            bool isTransPresent = Conversions.ToDouble(Conversions.ToString(mat.Color) + Conversions.ToString(0xFFU)) != 0xFFU;
            if (mat.HasTexture)
            {
                var switchExpr2 = mat.Type;
                switch (switchExpr2)
                {
                    case MaterialType.None:
                    case MaterialType.TextureSolid:
                    case MaterialType.ColorSolid:
                        {
                            alphaFormula = F3D_SETCOMBINE.Formula.Output(F3D_SETCOMBINE.ACMUX.ONE);
                            break;
                        }

                    case MaterialType.TextureAlpha:
                    case MaterialType.TextureTransparent:
                        {
                            // With Fog multiplying SHADE is not something you want because it will be alpha fog so just output TEXEL0 and hope it is fine
                            if (settings.EnableFog)
                            {
                                alphaFormula = F3D_SETCOMBINE.Formula.Output(F3D_SETCOMBINE.ACMUX.TEXEL0);
                            }
                            else
                            {
                                alphaFormula = F3D_SETCOMBINE.Formula.Multiply((byte)F3D_SETCOMBINE.ACMUX.TEXEL0, (byte)F3D_SETCOMBINE.ACMUX.SHADE);
                            }

                            break;
                        }

                    case MaterialType.ColorTransparent:
                        {
                            if (isTransPresent)
                            {
                                alphaFormula = F3D_SETCOMBINE.Formula.Multiply((byte)F3D_SETCOMBINE.ACMUX.TEXEL0, (byte)F3D_SETCOMBINE.ACMUX.ENVIRONMENT);
                            }
                            else if (settings.EnableFog)
                            {
                                alphaFormula = F3D_SETCOMBINE.Formula.Output(F3D_SETCOMBINE.ACMUX.TEXEL0);
                            }
                            else
                            {
                                alphaFormula = F3D_SETCOMBINE.Formula.Multiply((byte)F3D_SETCOMBINE.ACMUX.TEXEL0, (byte)F3D_SETCOMBINE.ACMUX.SHADE);
                            }

                            break;
                        }
                }
            }
            else
            {
                var switchExpr3 = mat.Type;
                switch (switchExpr3)
                {
                    case MaterialType.None:
                    case MaterialType.TextureSolid:
                    case MaterialType.ColorSolid:
                        {
                            alphaFormula = F3D_SETCOMBINE.Formula.Output(F3D_SETCOMBINE.ACMUX.ONE);
                            break;
                        }

                    case MaterialType.TextureAlpha:
                    case MaterialType.TextureTransparent:
                        {
                            // With Fog multiplying SHADE is not something you want because it will be alpha fog so just output TEXEL0
                            if (settings.EnableFog)
                            {
                                alphaFormula = F3D_SETCOMBINE.Formula.Output(F3D_SETCOMBINE.ACMUX.ONE);
                            }
                            else
                            {
                                alphaFormula = F3D_SETCOMBINE.Formula.Output(F3D_SETCOMBINE.ACMUX.SHADE);
                            }

                            break;
                        }

                    case MaterialType.ColorTransparent:
                        {
                            if (isTransPresent)
                            {
                                // If there is no material, may as well provide more options for alpha modulate
                                if (settings.EnableFog)
                                {
                                    alphaFormula = F3D_SETCOMBINE.Formula.Output(F3D_SETCOMBINE.ACMUX.ENVIRONMENT);
                                }
                                else
                                {
                                    alphaFormula = F3D_SETCOMBINE.Formula.Multiply((byte)F3D_SETCOMBINE.ACMUX.ENVIRONMENT, (byte)F3D_SETCOMBINE.ACMUX.SHADE);
                                }
                            }
                            else if (settings.EnableFog)
                            {
                                alphaFormula = F3D_SETCOMBINE.Formula.Output(F3D_SETCOMBINE.ACMUX.ONE);
                            }
                            else
                            {
                                alphaFormula = F3D_SETCOMBINE.Formula.Output(F3D_SETCOMBINE.ACMUX.SHADE);
                            }

                            break;
                        }
                }
            }

            cmd = F3D_SETCOMBINE.Make(colorFormula, alphaFormula, settings.EnableFog);
            if (!string.IsNullOrEmpty(cmd) && (lastCmd ?? "") != (cmd ?? ""))
            {
                ImpF3D(cmd);
                lastCmd = cmd;
            }
        }

        private void ImpTriCmds(Material mat, FvGroup grp, int offset, ref bool enabledVertexColors)
        {
            if (grp.VertexDataCount < 3)
                return;
            uint off = (uint)(startSegOffset + offset);
            int amount = grp.VertexDataCount * 0x10;
            if (mat.EnableScrolling)
            {
                AddScrollingTexture(grp, Conversions.ToInteger(off), Conversions.ToInteger(mat.Offset), mat.Name);
            }

            if (grp.EnableVertexColors)
            {
                if (!enabledVertexColors)
                {
                    ImpF3D("B6 00 00 00 00 02 00 00");
                    enabledVertexColors = true;
                }
            }
            else if (enabledVertexColors)
            {
                ImpF3D("B7 00 00 00 00 02 00 00");
                enabledVertexColors = false;
            }

            ImpF3D($"04 {Microsoft.VisualBasic.Conversion.Hex(amount - 0x10 & 0xFF)} 00 {Microsoft.VisualBasic.Conversion.Hex(amount & 0xFF)} {Microsoft.VisualBasic.Conversion.Hex(curSeg)} {Microsoft.VisualBasic.Conversion.Hex(off >> 16 & (long)0xFF)} {Microsoft.VisualBasic.Conversion.Hex(off >> 8 & (long)0xFF)} {Microsoft.VisualBasic.Conversion.Hex(off & (long)0xFF)}");
            for (int i = 0, loopTo = grp.NumTri - 1; i <= loopTo; i++)
            {
                byte a = Conversions.ToByte(grp.indexList[i * 3] * 0xA);
                byte b = Conversions.ToByte(grp.indexList[i * 3 + 1] * 0xA);
                byte c = Conversions.ToByte(grp.indexList[i * 3 + 2] * 0xA);
                ImpF3D($"BF 00 00 00 00 {Microsoft.VisualBasic.Conversion.Hex(a)} {Microsoft.VisualBasic.Conversion.Hex(b)} {Microsoft.VisualBasic.Conversion.Hex(c)}");
            }
        }

        private void ResetCrystalEffectCommands(ref bool hasCrystalEffectEnabled, ref bool needToResetCrystalEffectCommands)
        {
            ImpF3D("B6 00 00 00 00 04 00 00");
            ImpF3D("BB 00 00 01 FF FF FF FF");
            hasCrystalEffectEnabled = false;
            needToResetCrystalEffectCommands = false;
        }

        private void ImpMaterialCmds(Material mat, ref bool needToReShiftTMEM, ref bool hasCrystalEffectEnabled, ref bool needToResetCrystalEffectCommands)
        {
            if (mat.EnableCrystalEffect && !hasCrystalEffectEnabled)
            {
                ImpF3D("B7 00 00 00 00 04 00 00");
                ImpF3D("BB 00 00 01 08 00 08 00");
                hasCrystalEffectEnabled = true;
                needToResetCrystalEffectCommands = true;
            }
            else if (needToResetCrystalEffectCommands)
            {
                ResetCrystalEffectCommands(ref hasCrystalEffectEnabled, ref needToResetCrystalEffectCommands);
            }

            if (mat.HasPalette)
            {
                ImpCmdFD(mat.PaletteOffset, N64Codec.RGBA16);
                ImpF3D("F5 00 01 00 01 00 00 00");
                ushort num = Conversions.ToUShort(Conversions.ToLong(mat.PaletteSize / (double)2 - 1) << 6);
                ImpF3D($"F0 00 00 00 01 {Microsoft.VisualBasic.Conversion.Hex(num >> 8 & 0xFF)} {Microsoft.VisualBasic.Conversion.Hex(num & 0xFF)} 00");
            }

            if (mat.HasTexture)
            {
                ImpCmdFD(mat.Offset, mat.TexType);
                ImpCmdF5_First(mat.TexType);
                ImpF3D("E6 00 00 00 00 00 00 00");
                AddCmdF3(mat);
                ImpF3D("E7 00 00 00 00 00 00 00");
                ImpCmdF5_Second(mat, mat.TexWidth, mat.TexHeight);
                AddCmdF2(mat);
            }
        }

        private void AddScrollingTexture(FvGroup grp, int vertPtr, int matAddr, string matName)
        {
            var scrollTex = new ScrollTex(Conversions.ToInteger(curSeg) << 24 | vertPtr, Conversions.ToByte(grp.VertexDataCount), matAddr, matName);
            scrollTexts.Add(scrollTex);
        }

        private void MergeScrollingTextures()
        {
            short curScrollingGroupID = 0;
            var scrollingGroups = new Dictionary<int, short>();
            scrollTexts = new List<ScrollTex>(scrollTexts.OrderBy(n => n.Offset));
            short getScrollingGroup(int curMatAddr) { if (scrollingGroups.ContainsKey(curMatAddr)) { return scrollingGroups[curMatAddr]; } else { short newID = curScrollingGroupID; scrollingGroups.Add(curMatAddr, newID); curScrollingGroupID += 1; return newID; } };
            while (scrollTexts.Count > 0)
            {
                int startOff = scrollTexts[0].Offset;
                int endOff = startOff + scrollTexts[0].VertsCount * 0x10;
                int count = 0;
                int curMatAddr = scrollTexts[0].MaterialAddress;
                string curMatName = scrollTexts[0].MaterialName;
                foreach (ScrollTex st in scrollTexts)
                {
                    if (st.MaterialAddress == curMatAddr)
                    {
                        if (st.Offset <= endOff)
                        {
                            if ((endOff - startOff) / (double)0x10 <= ushort.MaxValue)
                            {
                                int newEndOffset = st.Offset + st.VertsCount * 0x10;
                                endOff = newEndOffset;
                            }
                            else
                            {
                                break;
                            }
                        }
                        else if (st.Offset > endOff)
                        {
                            break;
                        }

                        count += 1;
                    }
                    else
                    {
                        break;
                    }
                }

                int vertsCount = (int)((endOff - startOff) / (double)0x10);
                if (vertsCount > 0)
                {
                    short groupID = getScrollingGroup(curMatAddr);
                    scrollTexts.RemoveRange(0, count);
                    conRes.ScrollingCommands.Add(new ManagedScrollingTexture(Conversions.ToUShort(vertsCount), startOff, groupID));
                    conRes.ScrollingNames.AddIfNotContainsKey(groupID, curMatName);
                }
            }
        }

        private void ImpColorCmdFB(Material mat)
        {
            byte r = Conversions.ToByte(mat.Color >> 24 & (long)0xFF);
            byte g = Conversions.ToByte(mat.Color >> 16 & (long)0xFF);
            byte b = Conversions.ToByte(mat.Color >> 8 & (long)0xFF);
            ImpF3D($"FB 00 00 00 {Microsoft.VisualBasic.Conversion.Hex(r)} {Microsoft.VisualBasic.Conversion.Hex(g)} {Microsoft.VisualBasic.Conversion.Hex(b)} {Microsoft.VisualBasic.Conversion.Hex(mat.Opacity)}");
        }

        private void AlignPosition()
        {
            impdata.RoundUpPosition();
        }

        /// <summary>
        /// Adds a command that is requied on the end of a display list if CI textures are enabled
        /// </summary>
        private void ShiftTMEMBack()
        {
            ImpF3D("BA 00 0E 02 00 00 00 00");
        }

        /// <summary>
        /// Adds a command to enable CI textures
        /// </summary>
        private void SetOtherMode_H()
        {
            ImpF3D("BA 00 0E 02 00 00 80 00");
        }

        private void ImportObj(Pilz.S3DFileParser.Object3D model)
        {
            bool enabledVertexColors;
            bool enableForcing = settings.ForceDisplaylist != -1;
            uint importStart = 0;
            uint startVerts = 0;
            bool needToRevertShiftTMEM = false;
            Material lastMaterial = null;
            uint lastFBColor = default;
            bool hasCrystalEffectEnabled, needToResetCrystalEffectCommands;
            bool ciEnabled;
            var citextypes = new[] { N64Codec.CI4, N64Codec.CI8 };
            string lastCmdFC;
            var dlsToCreate = new List<DisplaylistProps>();
            var dicMatDlIDs = new Dictionary<Material, int>();
            ProcessObject3DModel(model);
            conRes.PtrStart = Conversions.ToUInteger(CurSegAddress | impdata.Position);
            importStart = Conversions.ToUInteger(impdata.Position);

            // Write default color
            impdata.Write(defaultColor);

            // Remove duplicated textures
            // FIXME: This function does not account for materials properties like Opacity
            // MergeDuplicatedTextures()

            // Write materials
            foreach (Material mt in materials)
            {
                if (mt.HasTexture)
                {
                    mt.Offset = Conversions.ToUInteger(impdata.Position);
                    impdata.Write(mt.Texture.Data);
                    AlignPosition();
                    if (mt.HasPalette)
                    {
                        mt.PaletteOffset = Conversions.ToUInteger(impdata.Position);
                        impdata.Write(mt.Texture.Palette);
                        AlignPosition();
                    }
                }
            }

            // Prepaire vertices
            BuildVertexGroups();
            removeDuplicateVertices(settings.ReduceVertLevel);

            // Write vertices
            conRes.PtrVertex = Conversions.ToUInteger(CurSegAddress | impdata.Position);
            startVerts = Conversions.ToUInteger(impdata.Position);
            foreach (VertexGroupList mp in vertexGroups)
            {
                for (int g = 0, loopTo = mp.GroupsCount - 1; g <= loopTo; g++)
                {
                    if (mp.FinalVertexGroups[g].VertexDataCount >= 1)
                    {
                        for (int i = 0, loopTo1 = mp.FinalVertexGroups[g].VertexDataCount - 1; i <= loopTo1; i++)
                        {
                            var data = mp.FinalVertexGroups[g].FinalVertexData[i].Data;
                            impdata.Write(data);
                        }
                    }
                }
            }

            int createDefaultDL(DefaultGeolayers layerID)
            {
                DisplaylistProps dlProp = null;
                int newLayerID = ((int)layerID + 1) * -1;
                foreach (DisplaylistProps dl in dlsToCreate)
                {
                    if (dlProp is null && dl.ID == newLayerID)
                    {
                        dlProp = dl;
                    }
                }

                if (dlProp is null)
                {
                    dlProp = new DisplaylistProps(newLayerID);
                }

                dlProp.Layer = layerID;
                if (!dlsToCreate.Contains(dlProp))
                {
                    dlsToCreate.Add(dlProp);
                }

                return dlProp.ID;
            };
            int createCustomDL(int dlID)
            {
                DisplaylistProps dlProp = null;

                // Search dlProp
                foreach (var prop in settings.TextureFormatSettings.CustomDisplayLists)
                {
                    if (dlProp is null && prop.ID == dlID)
                    {
                        dlProp = prop;
                    }
                }

                if (!dlsToCreate.Contains(dlProp))
                {
                    dlsToCreate.Add(dlProp);
                }

                return dlProp.ID;
            };

            // Check which DLs should be created
            if (enableForcing)
            {
                int dlID = createDefaultDL((DefaultGeolayers)settings.ForceDisplaylist);
                foreach (Material mat in materials)
                    dicMatDlIDs.Add(mat, dlID);
            }
            else
            {
                foreach (Material mat in materials)
                {
                    int dlID = -1;
                    var switchExpr = mat.DisplaylistSelection.SelectionMode;
                    switch (switchExpr)
                    {
                        case DisplaylistSelectionMode.Automatic:
                            {
                                if (mat.HasTransparency)
                                {
                                    dlID = createDefaultDL(DefaultGeolayers.Translucent);
                                }
                                else if (mat.HasTextureAlpha)
                                {
                                    dlID = createDefaultDL(DefaultGeolayers.Alpha);
                                }
                                else
                                {
                                    dlID = createDefaultDL(DefaultGeolayers.Solid);
                                }

                                break;
                            }

                        case DisplaylistSelectionMode.Default:
                            {
                                dlID = createDefaultDL(mat.DisplaylistSelection.DefaultGeolayer);
                                break;
                            }

                        case DisplaylistSelectionMode.Custom:
                            {
                                dlID = createCustomDL(mat.DisplaylistSelection.CustomDisplaylistID);
                                break;
                            }
                    }

                    dicMatDlIDs.Add(mat, dlID);
                }
            }

            // Create DLs
            foreach (DisplaylistProps dlProps in dlsToCreate)
            {
                // Add Geopointer
                conRes.PtrGeometry.Add(new Geopointer((byte)dlProps.Layer, Conversions.ToInteger(CurSegAddress | impdata.Position)));

                // Reset some stuff
                enabledVertexColors = false;
                hasCrystalEffectEnabled = false;
                needToResetCrystalEffectCommands = false;
                ciEnabled = false;
                lastMaterial = null;
                lastFBColor = default;
                lastCmdFC = string.Empty;

                // Create DL
                ImpF3D("E7 00 00 00 00 00 00 00");
                if (settings.EnableFog)
                    ImpF3D("B9 00 02 01 00 00 00 00");
                ImpF3D("B7 00 00 00 00 00 00 00");
                ImpF3D("BB 00 00 01 FF FF FF FF");
                ImpF3D("E8 00 00 00 00 00 00 00");
                ImpF3D("E6 00 00 00 00 00 00 00");
                ImpF3D("03 88 00 10 0E 00 00 00");
                ImpF3D("03 86 00 10 0E 00 00 08");
                if (settings.EnableFog)
                    ImpFogStart((int)dlProps.Layer);
                for (int i = 0, loopTo2 = vertexGroups.Count - 1; i <= loopTo2; i++)
                {
                    var mp = vertexGroups[i];
                    if (dicMatDlIDs[mp.Material] != dlProps.ID)
                        continue;
                    bool iscitexture = citextypes.Contains(mp.Material.TexType);
                    bool waslastcitexture = lastMaterial is object && citextypes.Contains(lastMaterial.TexType);

                    // CI Texture things
                    if (iscitexture && !waslastcitexture)
                    {
                        SetOtherMode_H();
                        ciEnabled = true;
                    }
                    else if (!iscitexture && waslastcitexture)
                    {
                        ShiftTMEMBack();
                    }

                    // Geomode
                    if (mp.Material.EnableGeoMode)
                    {
                        ImpF3D("B6 00 00 00 FF FF FF FF");
                        ImpF3D($"B7 00 00 00 {Microsoft.VisualBasic.Conversion.Hex(mp.Material.GeoMode >> 24 & (long)0xFF)} {Microsoft.VisualBasic.Conversion.Hex(mp.Material.GeoMode >> 16 & (long)0xFF)} {Microsoft.VisualBasic.Conversion.Hex(mp.Material.GeoMode >> 8 & (long)0xFF)} {Microsoft.VisualBasic.Conversion.Hex(mp.Material.GeoMode & (long)0xFF)}");
                    }

                    if (lastMaterial != mp.Material)
                    {
                        lastMaterial = mp.Material;
                        AddCmdFC(mp.Material, ref lastCmdFC);
                        if (mp.Material.Type == MaterialType.ColorSolid | mp.Material.Type == MaterialType.ColorTransparent)
                        {
                            if (lastFBColor != mp.Material.Color)
                            {
                                ImpColorCmdFB(mp.Material);
                            }
                        }

                        ImpMaterialCmds(mp.Material, ref needToRevertShiftTMEM, ref hasCrystalEffectEnabled, ref needToResetCrystalEffectCommands);
                    }

                    int grpOff = 0;
                    for (int ii = 0, loopTo3 = mp.GroupsCount - 1; ii <= loopTo3; ii++)
                    {
                        ImpTriCmds(mp.Material, mp.FinalVertexGroups[ii], (int)(startVerts + (mp.StartIndex + grpOff)), ref enabledVertexColors);
                        grpOff += mp.FinalVertexGroups[ii].VertexDataCount * 0x10;
                    }

                    if (mp.Material.EnableGeoMode)
                    {
                        if (i + 1 < vertexGroups.Count && vertexGroups[i + 1].Material.EnableGeoMode)
                            continue;
                        ImpF3D("B6 00 00 00 FF FF FF FF");
                        ImpF3D("B7 00 00 00 00 02 20 05");
                    }
                }

                if (enabledVertexColors)
                    ImpF3D("B7 00 00 00 00 02 00 00");
                if (settings.EnableFog)
                    ImpFogEnd((int)dlProps.Layer);
                ImpF3D("FC FF FF FF FF FE 79 3C");
                ImpF3D("BB 00 00 00 FF FF FF FF");
                if (needToResetCrystalEffectCommands)
                    ResetCrystalEffectCommands(ref hasCrystalEffectEnabled, ref needToResetCrystalEffectCommands);
                if (ciEnabled)
                    ShiftTMEMBack();
                ImpF3D("B8 00 00 00 00 00 00 00");
                MergeScrollingTextures();
            }

            ResetVariables();
        }

        /// <summary>
        /// Converts a Object3D to an N64 Model and an SM64 Collision.
        /// </summary>
        /// <param name="s">The stream where to write the Fast3D and Collision data.</param>
        /// <param name="settings">The convert settings.</param>
        /// <param name="input">The input model.</param>
        /// <returns></returns>
        public ConvertResult ConvertModel(Stream s, ConvertSettings settings, Pilz.S3DFileParser.Object3D input)
        {
            this.settings = settings;
            impdata = new BinaryStreamData(s);

            // Segmented Address
            if (settings.SegmentedAddress is object)
            {
                startSegOffset = (uint)(settings.SegmentedAddress & 0xFFFFFF);
                curSeg = (byte)(settings.SegmentedAddress >> 24 & 0xFF);
            }

            // Shading
            SetLightAndDarkValues(input.Shading);

            // Convert
            ImportObj(input);
            ResetVariables();
            return conRes;
        }
    }
}