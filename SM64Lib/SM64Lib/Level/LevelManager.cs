using System;
using System.Collections.Generic;
using System.Data;
using global::System.IO;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64Lib.Data;
using global::SM64Lib.Data.System;
using global::SM64Lib.Geolayout.Script;
using global::SM64Lib.Geolayout.Script.Commands;
using global::SM64Lib.Levels.Script;
using global::SM64Lib.Levels.Script.Commands;
using global::SM64Lib.Levels.ScrolTex;
using global::SM64Lib.Model;
using global::SM64Lib.SegmentedBanking;

namespace SM64Lib.Levels
{
    public class LevelManager : ILevelManager
    {
        public bool EnableLoadingAreaReverb { get; set; } = true;

        /// <summary>
        /// Loads a ROM Manager Level from ROM.
        /// </summary>
        /// <param name="lvl"></param>
        /// <param name="rommgr"></param>
        /// <param name="LevelID"></param>
        /// <param name="segAddress"></param>
        public virtual void LoadLevel(Level lvl, RomManager rommgr, ushort LevelID, uint segAddress)
        {
            int customBGStart = 0;
            int customBGEnd = 0;
            lvl.LevelID = LevelID;

            // Load Bank 0x19
            lvl.Bank0x19 = rommgr.GetSegBank(0x19);
            lvl.Bank0x19.ReadDataIfNull(rommgr.RomFile);

            // Close if not closed & re-open
            if (!lvl.Closed) lvl.Close();
            lvl.Closed = false;

            // Lade Levelscript
            lvl.Levelscript = new Levelscript();
            lvl.Levelscript.Read(rommgr, Conversions.ToInteger(segAddress));

            // Erstelle Areas / Lade Einstellungen
            bool AreaOnFly = false;
            LevelArea tArea = null;
            var CurrentLevelScriptCommands = lvl.Levelscript.ToArray();
            var cmdsToRemove = new List<LevelscriptCommand>();
            foreach (LevelscriptCommand c in CurrentLevelScriptCommands)
            {
                var switchExpr = c.CommandType;
                switch (switchExpr)
                {
                    case LevelscriptCommandTypes.StartArea:
                        AreaOnFly = true;
                        tArea = new RMLevelArea();
                        tArea.AreaID = clStartArea.GetAreaID(c);
                        tArea.GeolayoutOffset = clStartArea.GetSegGeolayoutAddr(c); // - bank0x19.BankAddress + bank0x19.RomStart
                        tArea.Geolayout.Read(rommgr, Conversions.ToInteger(tArea.GeolayoutOffset));
                        break;
                    case LevelscriptCommandTypes.EndOfArea:
                        tArea.Levelscript.Add(c);
                        lvl.Levelscript.Remove(c);
                        lvl.Areas.Add(tArea);
                        AreaOnFly = false;
                        break;
                    case LevelscriptCommandTypes.AreaMusic:
                        tArea.BGMusic = clAreaMusic.GetMusicID(c);
                        break;
                    case LevelscriptCommandTypes.AreaMusicSimple:
                        tArea.BGMusic = clAreaMusicSimple.GetMusicID(c);
                        break;
                    case LevelscriptCommandTypes.Tarrain:
                        tArea.TerrainType = (Geolayout.TerrainTypes)clTerrian.GetTerrainType(c);
                        break;
                    case LevelscriptCommandTypes.Normal3DObject:
                        var scrollTexAddrs = new List<int>(new[] { 0x400000, 0x401700 });
                        if (rommgr.RomConfig.ScrollTexConfig.UseCustomBehavior)
                            scrollTexAddrs.Add(rommgr.RomConfig.ScrollTexConfig.CustomBehaviorAddress);
                        if (scrollTexAddrs.Contains((int)clNormal3DObject.GetSegBehaviorAddr(c)))
                            tArea.ScrollingTextures.Add(new ManagedScrollingTexture(c));
                        else
                            tArea.Objects.Add(c);
                        break;
                    case LevelscriptCommandTypes.ConnectedWarp:
                        if ((new[] { 0xF0, 0xF1 }).Contains(clWarp.GetWarpID(c)))
                            tArea.WarpsForGame.Add(c);
                        else
                            tArea.Warps.Add(c);
                        break;
                    case LevelscriptCommandTypes.PaintingWarp:
                    case LevelscriptCommandTypes.InstantWarp:
                        tArea.Warps.Add(c);
                        break;
                    case LevelscriptCommandTypes.LoadRomToRam:
                        byte bankID = clLoadRomToRam.GetSegmentedID(c);
                        int startAddr = clLoadRomToRam.GetRomStart(c);
                        int endAddr = clLoadRomToRam.GetRomEnd(c);
                        switch (bankID)
                        {
                            case 0xA: // Background-Image
                                customBGStart = startAddr;
                                customBGEnd = endAddr - 0x140;
                                break;
                            case 0x7: // Global Object Bank
                                if (rommgr.GlobalModelBank?.CurSeg is object && startAddr == rommgr.GlobalModelBank.CurSeg.RomStart && endAddr == rommgr.GlobalModelBank.CurSeg.RomEnd)
                                {
                                    lvl.EnableGlobalObjectBank = true;
                                    lvl.LastGobCmdSegLoad = c;
                                }
                                break;
                            case 0x9:
                                if (((RMLevel)lvl).Config.EnableLocalObjectBank)
                                {
                                    lvl.EnableLocalObjectBank = true;
                                }
                                lvl.LastLobCmdSegLoad = c;
                                break;
                        }
                        break;
                    case LevelscriptCommandTypes.ShowDialog:
                        if (AreaOnFly)
                        {
                            tArea.ShowMessage.Enabled = true;
                            tArea.ShowMessage.DialogID = clShowDialog.GetDialogID(c);
                        }
                        break;
                    case LevelscriptCommandTypes.JumpBack:
                    case LevelscriptCommandTypes.JumpToSegAddr:
                        if (tArea is object)
                            cmdsToRemove.Add(c);
                        break;
                }

                if (AreaOnFly && !cmdsToRemove.Contains(c))
                {
                    lvl.Levelscript.Remove(c);
                    tArea.Levelscript.Add(c);
                }
            }

            // Lösche alle Jump-Commands aus dem Levelscript
            foreach (LevelscriptCommand cmd in cmdsToRemove)
            {
                lvl.Levelscript.Remove(cmd);
                cmd.Close();
            }

            // Lösche alle Objekte und Warps aus dem Levelscript
            var lvlscrptidstoremove = new[] { LevelscriptCommandTypes.Normal3DObject, LevelscriptCommandTypes.ConnectedWarp, LevelscriptCommandTypes.PaintingWarp, LevelscriptCommandTypes.InstantWarp };
            foreach (var a in lvl.Areas)
            {
                foreach (var c in a.Levelscript.Where(n => lvlscrptidstoremove.Contains(n.CommandType)).ToArray())
                    a.Levelscript.Remove(c);
            }

            // Load Local Object Bank
            if (lvl.LastLobCmdSegLoad is object)
            {
                var seg = new SegmentedBank()
                {
                    BankID = clLoadRomToRam.GetSegmentedID(lvl.LastLobCmdSegLoad),
                    RomStart = clLoadRomToRam.GetRomStart(lvl.LastLobCmdSegLoad),
                    RomEnd = clLoadRomToRam.GetRomEnd(lvl.LastLobCmdSegLoad)
                };
                lvl.LocalObjectBank.ReadFromSeg(rommgr, seg, ((RMLevel)lvl).Config.LocalObjectBank);
            }

            // Lese Custom Background Image
            var fs = new FileStream(rommgr.RomFile, FileMode.Open, FileAccess.Read);
            var br2 = new BinaryReader(fs);
            lvl.Background.Enabled = false;
            foreach (LevelArea a in lvl.Areas)
            {
                var bgglcmd = a.Geolayout.Geolayoutscript.GetFirst(GeolayoutCommandTypes.Background);
                if (cgBackground.GetBackgroundPointer(bgglcmd) == 0)
                {
                    a.Background.Type = AreaBGs.Color;
                    a.Background.Color = cgBackground.GetRrgbaColor(bgglcmd);
                }
                else
                {
                    a.Background.Type = AreaBGs.Levelbackground;
                    lvl.Background.ID = (Geolayout.BackgroundIDs)cgBackground.GetBackgroundID(bgglcmd);
                    lvl.Background.Enabled = true;
                }
            }

            if (customBGStart != 0)
            {
                lvl.Background.IsCustom = true;
            }

            foreach (int val in Enum.GetValues(typeof(Geolayout.BackgroundPointers)))
            {
                if (val != 0 && customBGStart == val)
                {
                    lvl.Background.IsCustom = false;
                }
            }

            if (lvl.Background.Enabled && lvl.Background.IsCustom) // .ID = Geolayout.BackgroundIDs.Custom Then
            {
                fs.Position = customBGStart;
                lvl.Background.ReadImage(fs, customBGStart);
            }

            int bank0x19RomStart;
            int bank0x19RomEnd;
            BinaryReader brToUse;
            bank0x19RomStart = 0;
            bank0x19RomEnd = lvl.Bank0x19.Length;
            brToUse = new BinaryReader(lvl.Bank0x19.Data);

            // Lese Area-Table
            foreach (LevelArea a in lvl.Areas)
            {
                // Fast3D-Daten
                brToUse.BaseStream.Position = bank0x19RomStart + 0x5F00 + a.AreaID * 0x10;
                a.Bank0x0EOffset = Conversions.ToUInteger(SwapInts.SwapInt32(brToUse.ReadInt32()));
                int romEnd0xE = SwapInts.SwapInt32(brToUse.ReadInt32());
                rommgr.SetSegBank(0xE, Conversions.ToInteger(a.Bank0x0EOffset), romEnd0xE, a.AreaID);

                // 2D-Kamera
                brToUse.BaseStream.Position = bank0x19RomStart + 0x5F0F + a.AreaID * 0x10;
                a.Enable2DCamera = Bits.GetBoolOfByte(brToUse.ReadByte(), 7);
            }

            // Lese Area-Modelle
            foreach (LevelArea a in lvl.Areas)
            {
                a.AreaModel.FromStream(fs, Conversions.ToInteger(a.Bank0x0EOffset), 0xE000000, a.Fast3DBankRomStart, a.Fast3DLength, a.Geolayout.Geopointers.ToArray(), a.CollisionPointer, rommgr.RomConfig.CollisionBaseConfig);
            }

            // Lese alle Box-Daten
            int CurrentBoxOffset = bank0x19RomStart + 0x6A00;
            foreach (LevelArea a in lvl.Areas)
            {
                // Clear special boxes
                a.SpecialBoxes.Clear();

                // Load special boxes
                a.SpecialBoxes.AddRange(SpecialBoxList.ReadTable(brToUse.BaseStream, SpecialBoxType.Water, bank0x19RomStart, bank0x19RomStart + 0x6000 + 0x50 * a.AreaID));
                a.SpecialBoxes.AddRange(SpecialBoxList.ReadTable(brToUse.BaseStream, SpecialBoxType.ToxicHaze, bank0x19RomStart, bank0x19RomStart + 0x6280 + 0x50 * a.AreaID));
                a.SpecialBoxes.AddRange(SpecialBoxList.ReadTable(brToUse.BaseStream, SpecialBoxType.Mist, bank0x19RomStart, bank0x19RomStart + 0x6500 + 0x50 * a.AreaID));

                for (int i = 0; i < a.SpecialBoxes.Count; i++)
                {
                    var boxdata = a.AreaModel.Collision.SpecialBoxes.ElementAtOrDefault(i);
                    if (boxdata is object)
                    {
                        a.SpecialBoxes[i].Y = boxdata.Y;
                    }
                }
            }

            // One-Bank-0xE-System
            lvl.OneBank0xESystemEnabled = true;

            // Act Selector
            General.PatchClass.Open(fs);
            lvl.ActSelector = General.PatchClass.get_ActSelector_Enabled(LevelID);

            // Hardcoded Camera
            lvl.HardcodedCameraSettings = General.PatchClass.get_HardcodedCamera_Enabled(LevelID);

            // Area Reverb
            if (EnableLoadingAreaReverb)
            {
                foreach (var area in lvl.Areas)
                {
                    if (area is RMLevelArea && area.AreaID >= 1 && area.AreaID <= 3)
                    {
                        fs.Position = 0xEE0C0 + lvl.LevelID * 3 + area.AreaID - 1;
                        ((RMLevelArea)area).ReverbLevel = (AreaReverbLevel)fs.ReadByte();
                    }
                }
            }

            fs.Close();
        }

        /// <summary>
        /// Saves a ROM Manager Level to ROM.
        /// </summary>
        /// <param name="lvl"></param>
        /// <param name="rommgr"></param>
        /// <param name="output"></param>
        /// <param name="curOff"></param>
        /// <returns></returns>
        public virtual LevelSaveResult SaveLevel(Level lvl, RomManager rommgr, BinaryData output, ref uint curOff)
        {
            var saveres = new LevelSaveResult();
            BinaryData data0x19;
            var lid = rommgr.LevelInfoData.GetByLevelID(lvl.LevelID);

            // Write Area Model & Update Scrolling Texture Vertex Pointers & Write Custom Object Bank
            var CollisionBoxTableIndex = new[] { 0, 0x32, 0x33 };
            foreach (LevelArea a in lvl.Areas)
            {
                a.SpecialBoxes.SortByHeight();
                a.Bank0x0EOffset = curOff;

                int oldModelStart = a.AreaModel.Fast3DBuffer.Fast3DBankStart;
                int newModelStart;
                int modelOffset;

                // Add the new water boxes
                a.AreaModel.Collision.SpecialBoxes.Clear();
                foreach (SpecialBox sp in a.SpecialBoxes)
                {
                    var boxdata = new Model.Collision.BoxData
                    {
                        X1 = sp.X1,
                        X2 = sp.X2,
                        Z1 = sp.Z1,
                        Z2 = sp.Z2,
                        Y = sp.Y,
                        Index = (short)CollisionBoxTableIndex[(int)sp.Type]
                    };

                    switch (sp.Type)
                    {
                        case SpecialBoxType.Water:
                            boxdata.Type = Model.Collision.BoxDataType.Water;
                            break;
                        case SpecialBoxType.Mist:
                            boxdata.Type = Model.Collision.BoxDataType.Mist;
                            break;
                        case SpecialBoxType.ToxicHaze:
                            boxdata.Type = Model.Collision.BoxDataType.ToxicHaze;
                            break;
                    }

                    a.AreaModel.Collision.SpecialBoxes.Add(boxdata);
                    CollisionBoxTableIndex[(int)sp.Type] += 1;
                }

                // Write Area Model
                ObjectModel.SaveResult res;
                res = a.AreaModel.ToBinaryData(output, (int)curOff, (int)curOff, 0xE000000, rommgr.RomConfig.CollisionBaseConfig);

                // Calculate Model Offset & Update Scrolling Texture Vertex Pointers
                newModelStart = a.AreaModel.Fast3DBuffer.Fast3DBankStart;
                modelOffset = newModelStart - oldModelStart;
                if (modelOffset != 0)
                {
                    a.UpdateScrollingTextureVertexPointer(modelOffset);
                }

                a.CollisionPointer = res.CollisionPointer;
                a.Geolayout.Geopointers.Clear();
                a.Geolayout.Geopointers.AddRange(res.GeoPointers.ToArray());
                curOff += (uint)(res.Length + 0x20);
                General.HexRoundUp2(ref curOff);

                a.Bank0xELength = (int)(curOff - a.Bank0x0EOffset);
            }

            // Write Background Image
            output.RoundUpPosition();
            int customBGStart = Conversions.ToInteger(curOff);
            int customBGEnd = 0;
            if (lvl.Background.IsCustom) // .ID = Geolayout.BackgroundIDs.Custom Then
            {
                // Write Custom Background
                lvl.Background.WriteImage(output.BaseStream, customBGStart);

                // Write Pointer Table
                var bgPtrTable = LevelBG.GetBackgroundPointerTable();
                output.Write(bgPtrTable, 0, bgPtrTable.Length);
                customBGEnd = customBGStart + lvl.Background.ImageLength + bgPtrTable.Length;
                curOff += (uint)lvl.Background.ImageLength + (uint)bgPtrTable.Length;
                General.HexRoundUp2(ref curOff);
            }

            // Generate & Write Local Object Bank
            uint localObjectBankRomStart = 0;
            uint localObjectBankRomEnd = 0;
            bool writeLocalObjectBank = lvl.LocalObjectBank.Models.Count > 0 && lvl.EnableLocalObjectBank;
            if (writeLocalObjectBank)
            {
                localObjectBankRomStart = curOff;
                curOff += (uint)lvl.LocalObjectBank.WriteToSeg(output, (int)curOff, 0x9, rommgr.RomConfig.CollisionBaseConfig);
                localObjectBankRomEnd = curOff;
                ((RMLevel)lvl).Config.LocalObjectBank = lvl.LocalObjectBank.Config;
                lvl.LocalObjectBank.WriteCollisionPointers(output);
            }
            ((RMLevel)lvl).Config.EnableLocalObjectBank = writeLocalObjectBank;

            // Get Bank 0x19
            if (lvl.Bank0x19 is null)
            {
                lvl.Bank0x19 = rommgr.SetSegBank(0x19, Conversions.ToInteger(curOff), (int)RomManagerSettings.DefaultLevelscriptSize);
                lvl.Bank0x19.Data = new MemoryStream();
                lvl.Bank0x19.Length = (int)RomManagerSettings.DefaultLevelscriptSize;
            }
            else
            {
                var oldData = lvl.Bank0x19.Data;
                lvl.Bank0x19 = rommgr.SetSegBank(0x19, Conversions.ToInteger(curOff), (int)(curOff + lvl.Bank0x19.Length));
                lvl.Bank0x19.Data = oldData;
            }

            data0x19 = new BinaryStreamData(lvl.Bank0x19.Data);
            saveres.Bank0x19 = lvl.Bank0x19;
            curOff += (uint)lvl.Bank0x19.Data.Length;
            General.HexRoundUp2(ref curOff);

            // Update Geolayouts
            foreach (LevelArea a in lvl.Areas)
            {
                // Update Backcolor Command
                var cmd = a.Geolayout.Geolayoutscript.GetFirst(GeolayoutCommandTypes.Background);
                if (a.Background.Type == AreaBGs.Levelbackground && lvl.Background.Enabled)
                {
                    cgBackground.SetBackgroundPointer(cmd, unchecked((int)0x802763D4));
                    cgBackground.SetBackgroundID(cmd, (short)lvl.Background.ID);
                }
                else
                {
                    cgBackground.SetBackgroundPointer(cmd, 0);
                    cgBackground.SetRgbaColor(cmd, a.Background.Color);
                }
            }

            // Write Geolayouts
            int geoOffset = 0x5F00;
            foreach (LevelArea a in lvl.Areas)
            {
                geoOffset -= General.HexRoundUp1(a.Geolayout.Length) + 0x50;
                a.GeolayoutOffset = (uint)(lvl.Bank0x19.BankAddress + geoOffset);
                a.Geolayout.Write(lvl.Bank0x19.Data, geoOffset);
                a.Geolayout.NewGeoOffset = lvl.Bank0x19.RomStart + geoOffset;
            }

            // Füge Show-Dialog-Command & 2D-Camera-Object ein
            foreach (LevelArea a in lvl.Areas)
            {
                // Show-Dialog-Command
                if (a.ShowMessage.Enabled)
                {
                    var cmdShowMsg = new LevelscriptCommand($"30 04 00 {a.ShowMessage.DialogID.ToString("X2")}");
                    int indexOf1E = a.Levelscript.IndexOfFirst(LevelscriptCommandTypes.EndOfArea);
                    a.Levelscript.Insert(indexOf1E, cmdShowMsg);
                }

                // 2D-Camera-Object
                var cmds2d = new List<LevelscriptCommand>();
                foreach (LevelscriptCommand obj in a.Objects)
                {
                    if (obj.CommandType == LevelscriptCommandTypes.Normal3DObject)
                    {
                        if (clNormal3DObject.GetSegBehaviorAddr(obj) == (long)0x130053C4) // Behav-ID: '0x130053C4
                        {
                            cmds2d.Add(obj);
                        }
                    }
                }

                if (a.Enable2DCamera)
                {
                    if (cmds2d.Count == 0)
                    {
                        var cmd = new LevelscriptCommand("24 18 1F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 13 00 53 C4");
                        a.Objects.Add(cmd);
                    }
                }
                else if (cmds2d.Count > 0)
                {
                    foreach (LevelscriptCommand cmd in cmds2d)
                        a.Objects.Remove(cmd);
                }
            }

            Levelscript lvlScript0E = null;
            Dictionary<byte, uint> areaobjwarpoffsetdic = null;
            SegmentedBank firstBank0xE = null;
            uint curFirstBank0xEOffset = 0;

            // Add Objects and Warps to new Levelscript
            lvlScript0E = new Levelscript();
            firstBank0xE = rommgr.SetSegBank(0xE, Conversions.ToInteger(curOff), 0);
            areaobjwarpoffsetdic = new Dictionary<byte, uint>();
            foreach (LevelArea a in lvl.Areas)
            {
                areaobjwarpoffsetdic.Add(a.AreaID, (uint)(firstBank0xE.BankAddress + curFirstBank0xEOffset));
                foreach (LevelscriptCommand c in a.Objects)
                {
                    lvlScript0E.Add(c);
                    curFirstBank0xEOffset += (uint)c.Length;
                }

                foreach (ManagedScrollingTexture c in a.ScrollingTextures)
                {
                    c.SaveProperties(rommgr.RomConfig.ScrollTexConfig);
                    lvlScript0E.Add(c.Command);
                    curFirstBank0xEOffset += (uint)c.Command.Length;
                }

                foreach (LevelscriptCommand c in a.Warps)
                {
                    lvlScript0E.Add(c);
                    curFirstBank0xEOffset += (uint)c.Length;
                }

                foreach (LevelscriptCommand c in a.WarpsForGame)
                {
                    lvlScript0E.Add(c);
                    curFirstBank0xEOffset += (uint)c.Length;
                }

                lvlScript0E.Add(new LevelscriptCommand("07 04 00 00"));
                curFirstBank0xEOffset += 4;
            }

            firstBank0xE.Length = (int)General.HexRoundUp1(curFirstBank0xEOffset);
            lvlScript0E.Write(output, firstBank0xE.RomStart);
            curOff += (uint)firstBank0xE.Length;

            // Füge Area dem Levelscript hinzu
            int cIndex2 = lvl.Levelscript.IndexOfFirst(LevelscriptCommandTypes.x1E);
            foreach (var a in lvl.Areas)
            {
                foreach (var c in a.Levelscript)
                {
                    lvl.Levelscript.Insert(cIndex2, c);
                    cIndex2 += 1;
                }
            }

            // Übernehme Level- und Areaeinstellungen
            int CurrentAreaIndex = 0;
            var areaobjwarpindextoinsertdic = new Dictionary<byte, int>();
            var areaidindex = new Dictionary<byte, byte>();
            LevelArea tArea = null;
            bool foundCmdShowMsg = false;
            LevelscriptCommand cmdBgSegLoad = null;
            LevelscriptCommand cmdGobSegLoad = null;
            LevelscriptCommand cmdGobJump = null;
            LevelscriptCommand cmdLobSegLoad = null;
            LevelscriptCommand cmdLobJump = null;
            var cmdsToInsertAt = new Dictionary<LevelscriptCommand, LevelscriptCommand>();
            var cmdsToRemove = new List<LevelscriptCommand>();
            foreach (var c in lvl.Levelscript)
            {
                var switchExpr1 = c.CommandType;
                switch (switchExpr1)
                {
                    case LevelscriptCommandTypes.StartArea:
                        {
                            tArea = lvl.Areas[CurrentAreaIndex];
                            byte areaid = tArea.AreaID;
                            areaidindex.Add(areaid, Conversions.ToByte(areaidindex.Count));
                            clStartArea.SetSegGeolayoutAddr(c, (uint)(lvl.Areas[CurrentAreaIndex].Geolayout.NewGeoOffset - lvl.Bank0x19.RomStart + lvl.Bank0x19.BankAddress));
                            clStartArea.SetAreaID(c, areaid);
                            areaobjwarpindextoinsertdic.Add(areaid, lvl.Levelscript.IndexOf(c) + 1);
                            break;
                        }

                    case LevelscriptCommandTypes.EndOfArea:
                        {
                            if (!foundCmdShowMsg && tArea.ShowMessage.Enabled)
                            {
                                var cmdShowMsg = new LevelscriptCommand($"30 04 00 {tArea.ShowMessage.DialogID.ToString("X2")}");
                                cmdsToInsertAt.Add((LevelscriptCommand)c, cmdShowMsg);
                            }

                            foundCmdShowMsg = false;
                            CurrentAreaIndex += 1;
                            tArea = null;
                            break;
                        }

                    case LevelscriptCommandTypes.AreaMusic:
                        {
                            clAreaMusic.SetMusicID((LevelscriptCommand)c, lvl.Areas[CurrentAreaIndex].BGMusic);
                            break;
                        }

                    case LevelscriptCommandTypes.AreaMusicSimple:
                        {
                            clAreaMusicSimple.SetMusicID((LevelscriptCommand)c, lvl.Areas[CurrentAreaIndex].BGMusic);
                            break;
                        }

                    case LevelscriptCommandTypes.Tarrain:
                        {
                            clTerrian.SetTerrainType((LevelscriptCommand)c, (byte)lvl.Areas[CurrentAreaIndex].TerrainType);
                            break;
                        }

                    case LevelscriptCommandTypes.LoadRomToRam:
                        {
                            var switchExpr2 = clLoadRomToRam.GetSegmentedID((LevelscriptCommand)c);
                            switch (switchExpr2)
                            {
                                case 0xE: // Bank 0xE
                                    clLoadRomToRam.SetRomStart((LevelscriptCommand)c, firstBank0xE.RomStart);
                                    clLoadRomToRam.SetRomEnd((LevelscriptCommand)c, firstBank0xE.RomEnd);
                                    break;
                                case 0xA:
                                    cmdBgSegLoad = (LevelscriptCommand)c;
                                    break;
                                case 0x7:
                                    if (lvl.LastGobCmdSegLoad == c)
                                    {
                                        cmdGobSegLoad = (LevelscriptCommand)c;
                                    }
                                    break;
                                case 0x9:
                                    if (lvl.LastLobCmdSegLoad == c)
                                    {
                                        cmdLobSegLoad = (LevelscriptCommand)c;
                                    }
                                    break;
                            }

                            break;
                        }

                    case LevelscriptCommandTypes.ShowDialog:
                        {
                            if ((bool)tArea?.ShowMessage.Enabled && !foundCmdShowMsg)
                            {
                                clShowDialog.SetDialogID((LevelscriptCommand)c, tArea.ShowMessage.DialogID);
                                foundCmdShowMsg = true;
                            }
                            else
                            {
                                cmdsToRemove.Add((LevelscriptCommand)c);
                            }

                            break;
                        }

                    case LevelscriptCommandTypes.JumpToSegAddr:
                        {
                            int bankID = clJumpToSegAddr.GetSegJumpAddr((LevelscriptCommand)c) >> 24;
                            switch(bankID)
                            {
                                case 0x7:
                                    cmdGobJump = (LevelscriptCommand)c;
                                    break;
                                case 0x9:
                                    cmdLobJump = (LevelscriptCommand)c;
                                    break;
                            }
                            break;
                        }
                }
            }

            // Füge Jump Commands zur ersten 0xE-Bank hinzu
            foreach (var e in areaobjwarpindextoinsertdic.OrderByDescending(n => n.Value))
            {
                uint segStartAddr = areaobjwarpoffsetdic[e.Key];
                lvl.Levelscript.Insert(e.Value, new LevelscriptCommand(new byte[] { 0x6, 8, 0, 0, Conversions.ToByte((long)(segStartAddr >> 24) & (long)0xFF), Conversions.ToByte((long)(segStartAddr >> 16) & (long)0xFF), Conversions.ToByte((long)(segStartAddr >> 8) & (long)0xFF), Conversions.ToByte((long)segStartAddr & (long)0xFF) }));
            }

            // Lösche Commands
            foreach (LevelscriptCommand cmd in cmdsToRemove)
                lvl.Levelscript.Remove(cmd);

            // Füge neue Commands ein
            foreach (KeyValuePair<LevelscriptCommand, LevelscriptCommand> kvp in cmdsToInsertAt)
            {
                int index = lvl.Levelscript.IndexOf(kvp.Key);
                lvl.Levelscript.Insert(index, kvp.Value);
            }

            // Füge Background-Command ein
            if (lvl.Background.Enabled)
            {
                var newbgcmd = cmdBgSegLoad ?? new LevelscriptCommand(new byte[] { 0x17, 0xC, 0, 0xA, 0, 0, 0, 0, 0, 0, 0, 0 });
                if (lvl.Background.IsCustom && lvl.Background.HasImage) // .ID = Geolayout.BackgroundIDs.Custom Then
                {
                    clLoadRomToRam.SetRomStart(newbgcmd, customBGStart);
                    clLoadRomToRam.SetRomEnd(newbgcmd, customBGEnd);
                }
                else
                {
                    clLoadRomToRam.SetRomStart(newbgcmd, (int)General.GetBackgroundAddressOfID(lvl.Background.ID, false));
                    clLoadRomToRam.SetRomEnd(newbgcmd, (int)General.GetBackgroundAddressOfID(lvl.Background.ID, true));
                }

                if (!lvl.Levelscript.Contains(newbgcmd))
                {
                    int indexoffirstx1e = lvl.Levelscript.IndexOfFirst(LevelscriptCommandTypes.x1D);
                    lvl.Levelscript.Insert(indexoffirstx1e, newbgcmd);
                }
            }
            else if (cmdBgSegLoad is object)
            {
                lvl.Levelscript.Remove(cmdBgSegLoad);
            }

            // Füge Global Object Bank Command ein
            if (lvl.EnableGlobalObjectBank)
            {
                var newgobjumpcmd = cmdGobJump ?? new LevelscriptCommand("06 08 00 00 07 00 00 00");
                var newgobcmd = cmdGobSegLoad ?? new LevelscriptCommand("17 0C 00 07 00 00 00 00 00 00 00 00");
                clLoadRomToRam.SetRomStart(newgobcmd, rommgr.GlobalModelBank.CurSeg.RomStart);
                clLoadRomToRam.SetRomEnd(newgobcmd, rommgr.GlobalModelBank.CurSeg.RomEnd);

                if (!lvl.Levelscript.Contains(newgobcmd))
                {
                    int indexoffirstx1d = lvl.Levelscript.IndexOfFirst(LevelscriptCommandTypes.x1D);
                    lvl.Levelscript.Insert(indexoffirstx1d, newgobcmd);
                    lvl.LastGobCmdSegLoad = newgobcmd;
                }

                if (!lvl.Levelscript.Contains(newgobjumpcmd))
                {
                    int indexoffirstx1d = lvl.Levelscript.IndexOfFirst(LevelscriptCommandTypes.x1D);
                    lvl.Levelscript.Insert(indexoffirstx1d + 1, newgobjumpcmd);
                }
            }
            else
            {
                if (cmdGobJump is object)
                {
                    lvl.Levelscript.Remove(cmdGobJump);
                }

                if (cmdGobSegLoad is object)
                {
                    lvl.Levelscript.Remove(cmdGobSegLoad);
                }
            }

            // Füge Local Object Bank Command ein
            if (writeLocalObjectBank)
            {
                var newlobjumpcmd = cmdLobJump ?? new LevelscriptCommand("06 08 00 00 09 00 00 00");
                var newlobcmd = cmdLobSegLoad ?? new LevelscriptCommand("17 0C 00 09 00 00 00 00 00 00 00 00");
                clLoadRomToRam.SetRomStart(newlobcmd, (int)localObjectBankRomStart);
                clLoadRomToRam.SetRomEnd(newlobcmd, (int)localObjectBankRomEnd);

                if (!lvl.Levelscript.Contains(newlobcmd))
                {
                    int indexoffirstx1d = lvl.Levelscript.IndexOfFirst(LevelscriptCommandTypes.x1D);
                    lvl.Levelscript.Insert(indexoffirstx1d, newlobcmd);
                    lvl.LastLobCmdSegLoad = newlobcmd;
                }

                if (!lvl.Levelscript.Contains(newlobjumpcmd))
                {
                    int indexoffirstx1d = lvl.Levelscript.IndexOfFirst(LevelscriptCommandTypes.x1D);
                    lvl.Levelscript.Insert(indexoffirstx1d + 1, newlobjumpcmd);
                }
            }
            else
            {
                if (cmdLobJump is object)
                {
                    lvl.Levelscript.Remove(cmdLobJump);
                }

                if (cmdLobSegLoad is object)
                {
                    lvl.Levelscript.Remove(cmdLobSegLoad);
                }
            }

            // Write Level Start (Start of Bank 0x19)
            lvl.Bank0x19.Data.Position = 0;
            foreach (byte b in Level.LevelscriptStart)
                data0x19.Write(b);

            // Write Levelscript
            lvl.Levelscript.Write(lvl.Bank0x19.Data, Conversions.ToInteger(data0x19.Position));

            // Parse Levelscript again!
            bool AreaOnFly = false;
            foreach (var c in lvl.Levelscript.ToArray())
            {
                var switchExpr3 = c.CommandType;
                switch (switchExpr3)
                {
                    case LevelscriptCommandTypes.StartArea:
                        {
                            AreaOnFly = true;
                            break;
                        }

                    case LevelscriptCommandTypes.EndOfArea:
                        {
                            AreaOnFly = false;
                            lvl.Levelscript.Remove(c);
                            break;
                        }
                }

                if (AreaOnFly)
                    lvl.Levelscript.Remove(c);
            }

            var bwToUse = data0x19 ?? output;

            // Write 4 checkbytes for the One-0xE-Bank-Per-Area-Code
            lvl.Bank0x19.Data.Position = 0x5FFC;
            bwToUse.Write(Conversions.ToInteger(0x4BC9189A));

            // Write Area Table
            foreach (LevelArea a in lvl.Areas)
            {
                uint off = (uint)(0x5F00 + a.AreaID * 0x10);
                lvl.Bank0x19.Data.Position = off;
                bwToUse.Write(Conversions.ToUInteger(a.Bank0x0EOffset));
                bwToUse.Write(Conversions.ToUInteger(a.Bank0x0EOffset + a.Bank0xELength));
                bwToUse.Write(Conversions.ToUInteger(0));
                bwToUse.Write(Conversions.ToByte(0x0));
                bwToUse.Write(Conversions.ToByte(0x0));
                bwToUse.Write(Conversions.ToByte(0x0));
                bwToUse.Write(Bits.ArrayToByte(new[] { false, false, false, false, false, false, false, a.Enable2DCamera }));
            }

            // Write SpecialBoxes
            int CurrentBoxOffset = 0x6A00;
            foreach (LevelArea a in lvl.Areas)
            {
                var TableIndex = new[] { 0, 0x32, 0x33 };
                var TableOffset = new[] { 0x6000 + 0x50 * a.AreaID, 0x6280 + 0x50 * a.AreaID, 0x6500 + 0x50 * a.AreaID };
                
                foreach (SpecialBoxType t in Enum.GetValues(typeof(SpecialBoxType)))
                {
                    foreach (SpecialBox w in a.SpecialBoxes.Where(n => n.Type == t))
                    {
                        // Write Table Entry
                        bwToUse.Position = TableOffset[(int)w.Type];
                        bwToUse.Write(Conversions.ToShort(TableIndex[(int)w.Type]));
                        bwToUse.Write(Conversions.ToShort(0x0));
                        bwToUse.Write(Conversions.ToInteger(CurrentBoxOffset + lvl.Bank0x19.BankAddress));
                        TableOffset[(int)w.Type] = Conversions.ToInteger(bwToUse.Position);

                        // Write Box Data
                        bwToUse.Position = CurrentBoxOffset;
                        foreach (byte b in w.ToArrayBoxData())
                            bwToUse.Write(b);
                        TableIndex[(int)w.Type] += 1;
                        CurrentBoxOffset += 0x20;
                    }
                }

                foreach (int i in TableOffset)
                {
                    bwToUse.Position = i;
                    bwToUse.Write(Conversions.ToUShort(0xFFFF));
                }
            }

            // Write Bank0x19
            lvl.Bank0x19.WriteData(output);

            // Hardcoded Camera Settings & Act Selector
            General.PatchClass.Open(output);
            General.PatchClass.set_HardcodedCamera_Enabled(lvl.LevelID, lvl.HardcodedCameraSettings);
            General.PatchClass.set_ActSelector_Enabled(lvl.LevelID, lvl.ActSelector);

            // Write Pointer to Levelscript
            output.Position = lid.Pointer;
            output.Write(Conversions.ToInteger(0x100019));
            output.Write(Conversions.ToUInteger(lvl.Bank0x19.RomStart));
            output.Write(Conversions.ToUInteger(lvl.Bank0x19.RomEnd));
            output.Write(Conversions.ToUInteger(0x1900001C));
            output.Write(Conversions.ToUInteger(0x7040000));

            // Write Area Reverb
            if (EnableLoadingAreaReverb)
            {
                foreach (var area in lvl.Areas)
                {
                    if (area is RMLevelArea && area.AreaID >= 1 && area.AreaID <= 3)
                    {
                        output.Position = 0xEE0C0 + lvl.LevelID * 3 + area.AreaID - 1;
                        output.Write((byte)((RMLevelArea)area).ReverbLevel);
                    }
                }
            }

            return saveres;
        }
    }
}