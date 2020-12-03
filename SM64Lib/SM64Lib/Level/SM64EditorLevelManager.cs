using System;
using System.Collections.Generic;
using System.Data;
using global::System.IO;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64Lib.Data;
using global::SM64Lib.Geolayout.Script;
using global::SM64Lib.Geolayout.Script.Commands;
using global::SM64Lib.Levels.Script;
using global::SM64Lib.Levels.Script.Commands;
using SM64Lib.Configuration;

namespace SM64Lib.Levels
{
    public class SM64EditorLevelManager : ILevelManager
    {

        /// <summary>
        /// Loads a SM64 Editor Level from ROM.
        /// </summary>
        /// <param name="lvl"></param>
        /// <param name="rommgr"></param>
        /// <param name="LevelID"></param>
        /// <param name="segAddress"></param>
        public void LoadLevel(Level lvl, RomManager rommgr, ushort LevelID, uint segAddress)
        {
            int customBGStart = 0;
            int customBGEnd = 0;
            lvl.LevelID = LevelID;

            // Load Bank 0x19
            lvl.Bank0x19 = rommgr.GetSegBank(0x19);
            lvl.Bank0x19.ReadDataIfNull(rommgr.RomFile);
            if (lvl.Bank0x19.Length < 0x10000)
            {
                lvl.Bank0x19.Length = 0x10000;
            }

            if (!lvl.Closed)
                lvl.Close();
            lvl.Closed = false;

            // Lade Levelscript
            lvl.Levelscript = new Levelscript();
            lvl.Levelscript.Read(rommgr, Conversions.ToInteger(segAddress));

            // Erstelle Areas / Lade Einstellungen
            bool AreaOnFly = false;
            LevelArea tArea = null;
            var CurrentLevelScriptCommands = lvl.Levelscript.ToArray();
            var cmdsToRemove = new List<LevelscriptCommand>();
            LevelArea firstArea = null;
            foreach (LevelscriptCommand c in CurrentLevelScriptCommands)
            {
                var switchExpr = c.CommandType;
                switch (switchExpr)
                {
                    case LevelscriptCommandTypes.StartArea:
                        {
                            AreaOnFly = true;
                            tArea = new SM64ELevelArea();
                            if (firstArea is null)
                                firstArea = tArea;
                            tArea.AreaID = clStartArea.GetAreaID(c);
                            tArea.GeolayoutOffset = clStartArea.GetSegGeolayoutAddr(c);
                            tArea.Geolayout.Read(rommgr, Conversions.ToInteger(tArea.GeolayoutOffset));
                            break;
                        }

                    case LevelscriptCommandTypes.EndOfArea:
                        {
                            tArea.Levelscript.Add(c);
                            lvl.Levelscript.Remove(c);
                            lvl.Areas.Add(tArea);
                            AreaOnFly = false;
                            break;
                        }

                    case LevelscriptCommandTypes.AreaMusic:
                        {
                            tArea.BGMusic = clAreaMusic.GetMusicID(c);
                            break;
                        }

                    case LevelscriptCommandTypes.AreaMusicSimple:
                        {
                            tArea.BGMusic = clAreaMusicSimple.GetMusicID(c);
                            break;
                        }

                    case LevelscriptCommandTypes.Tarrain:
                        {
                            tArea.TerrainType = (Geolayout.TerrainTypes)clTerrian.GetTerrainType(c);
                            break;
                        }

                    case LevelscriptCommandTypes.Normal3DObject:
                        {
                            if (clNormal3DObject.GetSegBehaviorAddr(c) == (long)0x13003420)
                            {
                                tArea.ScrollingTextures.Add(new ScrolTex.ManagedScrollingTexture(c));
                            }
                            else
                            {
                                tArea.Objects.Add(c);
                            }

                            break;
                        }

                    case LevelscriptCommandTypes.ConnectedWarp:
                        {
                            if ((new[] { 0xF0, 0xF1 }).Contains(clWarp.GetWarpID(c)))
                            {
                                tArea.WarpsForGame.Add(c);
                            }
                            else
                            {
                                tArea.Warps.Add(c);
                            }

                            break;
                        }

                    case LevelscriptCommandTypes.PaintingWarp:
                    case LevelscriptCommandTypes.InstantWarp:
                        {
                            tArea.Warps.Add(c);
                            break;
                        }

                    case LevelscriptCommandTypes.LoadRomToRam:
                        {
                            byte bankID = clLoadRomToRam.GetSegmentedID(c);
                            int startAddr = clLoadRomToRam.GetRomStart(c);
                            int endAddr = clLoadRomToRam.GetRomEnd(c);
                            switch (bankID)
                            {
                                case 0xA: // Background-Image
                                    {
                                        customBGStart = startAddr;
                                        customBGEnd = endAddr - 0x140;
                                        break;
                                    }

                                case 0xE:
                                    {
                                        rommgr.SetSegBank(bankID, startAddr, endAddr);
                                        break;
                                    }
                            }

                            break;
                        }

                    case LevelscriptCommandTypes.ShowDialog:
                        {
                            if (AreaOnFly)
                            {
                                tArea.ShowMessage.Enabled = true;
                                tArea.ShowMessage.DialogID = clShowDialog.GetDialogID(c);
                            }

                            break;
                        }

                    case LevelscriptCommandTypes.JumpBack:
                    case LevelscriptCommandTypes.JumpToSegAddr:
                        {
                            if (tArea is object)
                                cmdsToRemove.Add(c);
                            break;
                        }
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

            // Stelle frisches Levelscript wieder her
            lvl.CreateNewLevelscript();

            // Lösche alle Objekte und Warps aus dem Levelscript
            var lvlscrptidstoremove = new[] { LevelscriptCommandTypes.Normal3DObject, LevelscriptCommandTypes.ConnectedWarp, LevelscriptCommandTypes.PaintingWarp, LevelscriptCommandTypes.InstantWarp };
            foreach (var a in lvl.Areas)
            {
                foreach (var c in a.Levelscript.Where(n => lvlscrptidstoremove.Contains(n.CommandType)).ToArray())
                    a.Levelscript.Remove(c);
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

            if (lvl.Background.Enabled && lvl.Background.ID == Geolayout.BackgroundIDs.Custom)
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

            // Lese Area-Modelle
            var modelBank = rommgr.GetSegBank(0xE);
            int curMdlStartOffset = modelBank.RomStart;
            for (int i = 0, loopTo = lvl.Areas.Count - 1; i <= loopTo; i++)
            {
                var a = lvl.Areas[i];
                int newEndOffset = GetModelEnd(fs, modelBank.RomStart, Conversions.ToByte(i));
                a.Bank0x0EOffset = Conversions.ToUInteger(curMdlStartOffset);
                rommgr.SetSegBank(0xE, Conversions.ToInteger(a.Bank0x0EOffset), newEndOffset, a.AreaID);
                a.AreaModel.Collision = new Model.Collision.CollisionMap();
                a.AreaModel.Collision.FromStream(fs, modelBank.SegToRomAddr(a.CollisionPointer), new CollisionBasicConfig());
                a.AreaModel.Fast3DBuffer = new Model.Fast3D.Fast3DBuffer();
                a.AreaModel.FromStream(fs, modelBank.RomStart, 0xE000000, curMdlStartOffset, newEndOffset - curMdlStartOffset, a.Geolayout.Geopointers.ToArray(), a.CollisionPointer, rommgr.RomConfig.CollisionBaseConfig);
                a.AreaModel.Collision.SpecialBoxes.Clear();
                curMdlStartOffset = newEndOffset;
            }

            // Lese alle Box-Daten
            firstArea.SpecialBoxes.Clear();
            firstArea.SpecialBoxes.AddRange(SpecialBoxList.ReadTable(brToUse.BaseStream, SpecialBoxType.Water, bank0x19RomStart, bank0x19RomStart + 0x1810));
            firstArea.SpecialBoxes.AddRange(SpecialBoxList.ReadTable(brToUse.BaseStream, SpecialBoxType.ToxicHaze, bank0x19RomStart, bank0x19RomStart + 0x1850));
            firstArea.SpecialBoxes.AddRange(SpecialBoxList.ReadTable(brToUse.BaseStream, SpecialBoxType.Mist, bank0x19RomStart, bank0x19RomStart + 0x18A0));
            var areaWithBoxData = lvl.Areas.FirstOrDefault(n => n.AreaModel.Collision.SpecialBoxes.Any());
            if (areaWithBoxData is object)
            {
                for (int i = 0, loopTo1 = firstArea.SpecialBoxes.Count - 1; i <= loopTo1; i++)
                {
                    var boxdata = firstArea.AreaModel.Collision.SpecialBoxes.ElementAtOrDefault(i);
                    if (boxdata is object)
                    {
                        firstArea.SpecialBoxes[i].Y = boxdata.Y;
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
            fs.Close();

            // Object-Banks
            lvl.MyObjectBanks.Clear();
            lvl.MyObjectBanks.Add(0xC, null);
            lvl.MyObjectBanks.Add(0xD, null);
            lvl.MyObjectBanks.Add(0x9, null);
        }

        public LevelSaveResult SaveLevel(Level lvl, RomManager rommgr, BinaryData output, ref uint curOff)
        {
            throw new NotImplementedException();
        }

        private static int GetModelEnd(Stream s, int startPos, byte areaIndex)
        {
            byte cb = 0;
            int Ausnahmen = 0;
            s.Position = startPos;
            bool ende = false;

            do
            {
                cb = Conversions.ToByte(s.ReadByte());
                if (s.Position >= s.Length - 1)
                    return Conversions.ToInteger(s.Length);
                else if (cb == 0x1)
                {
                    var haveFound = true;
                    s.Position -= 1;

                    for (int i = 1; i <= 0x100; i++)
                    {
                        if (haveFound && s.ReadByte() != 0x1)
                            haveFound = false;
                    }

                    if (haveFound)
                    {
                        if (Ausnahmen == areaIndex)
                            ende = true;
                        else
                            Ausnahmen += 1;
                    }
                }
            }
            while (!ende);

            return Conversions.ToInteger(s.Position);
        }
    }
}