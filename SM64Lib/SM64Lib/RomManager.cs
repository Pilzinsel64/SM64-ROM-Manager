using System;
using System.Collections.Generic;
using global::System.ComponentModel;
using System.Data;
using System.Diagnostics;
using global::System.IO;
using System.Linq;
using global::System.Text;
using Microsoft.VisualBasic.CompilerServices;
using global::Newtonsoft.Json.Linq;
using global::SM64Lib.Configuration;
using global::SM64Lib.Data;
using global::SM64Lib.Data.System;
using global::SM64Lib.EventArguments;
using global::SM64Lib.Levels;
using global::SM64Lib.Music;
using global::SM64Lib.Objects.ModelBanks;
using global::SM64Lib.SegmentedBanking;
using SM64Lib.Behaviors;
using SM64Lib.Objects.ObjectBanks;
using SM64Lib.ASM;
using SM64Lib.Exceptions;

namespace SM64Lib
{
    public class RomManager
    {

        // E v e n t s

        public event BeginLoadingRomEventHandler BeginLoadingRom;
        public delegate void BeginLoadingRomEventHandler(RomManager sender, EventArgs e);

        public event AfterRomLoadedEventHandler AfterRomLoaded;
        public delegate void AfterRomLoadedEventHandler(RomManager sender, EventArgs e);

        public event AfterLevelsLoadedEventHandler AfterLevelsLoaded;
        public delegate void AfterLevelsLoadedEventHandler(RomManager sender, EventArgs e);

        public event BeginLoadingMusicEventHandler BeginLoadingMusic;
        public delegate void BeginLoadingMusicEventHandler(RomManager sender, EventArgs e);

        public event AfterMusicLoadedEventHandler AfterMusicLoaded;
        public delegate void AfterMusicLoadedEventHandler(RomManager sender, EventArgs e);

        public event BeforeRomSaveEventHandler BeforeRomSave;
        public delegate void BeforeRomSaveEventHandler(RomManager sender, CancelEventArgs e);

        public event AfterRomSaveEventHandler AfterRomSave;
        public delegate void AfterRomSaveEventHandler(RomManager sender, EventArgs e);

        public event WritingNewProgramVersionEventHandler WritingNewProgramVersion;
        public delegate void WritingNewProgramVersionEventHandler(RomManager sender, RomVersionEventArgs e);

        // C o n s t a n t s

        public const string SUPER_MARIO_64_U_MD5HASH = "20b854b239203baf6c961b850a4a51a2";

        // F i e l d s

        private readonly Dictionary<byte, SegmentedBank> segBankList = new Dictionary<byte, SegmentedBank>();
        private readonly Dictionary<byte, Dictionary<byte, SegmentedBank>> areaSegBankList = new Dictionary<byte, Dictionary<byte, SegmentedBank>>();
        private Dictionary<string, RomVersion> dicUpdatePatches = new Dictionary<string, RomVersion>();
        private RomVersion myProgramVersion = new RomVersion();
        private readonly List<ushort> levelIDsToReset = new List<ushort>();
        private readonly List<Text.TextGroup> myTextGroups = new List<Text.TextGroup>();
        private string myGameName = null;
        private bool programVersion_loadedVersion = false;

        // P r o p e r t i e s

        public LevelInfoDataTabelList LevelInfoData { get; private set; } = new LevelInfoDataTabelList();
        public LevelList Levels { get; private set; } = new LevelList();
        public string RomFile { get; set; } = string.Empty;
        public bool IsSM64EditorMode { get; private set; } = false;
        public Text.Profiles.TextProfileInfo TextInfoProfile { get; set; }
        public MusicList MusicList { get; private set; } = new MusicList();
        public CustomModelBank GlobalModelBank { get; private set; } = new CustomModelBank();
        public BehaviorBank GlobalBehaviorBank { get; private set; } = null;
        public CustomAsmBank GlobalCustomAsmBank { get; private set; } = null;
        public ILevelManager LevelManager { get; private set; }
        public RomConfig RomConfig { get; private set; }
        public bool IsNewROM { get; private set; } = false;
        public CustomObjectCollection CustomObjects { get => RomConfig.GlobalObjectBank; }
        public Text.TextGroup[] TextGroups { get => myTextGroups.ToArray(); }

        /// <summary>
        /// Gets or sets the lastly used program version for this ROM.
        /// </summary>
        /// <returns></returns>
        public RomVersion ProgramVersion
        {
            get
            {
                RomVersion ver;
                if (!programVersion_loadedVersion)
                {
                    if (IsNewROM)
                    {
                        var romVerEventArgs = new RomVersionEventArgs(myProgramVersion);
                        WritingNewProgramVersion?.Invoke(this, romVerEventArgs);
                        myProgramVersion = romVerEventArgs.RomVersion;
                        ver = myProgramVersion;
                    }
                    else
                    {
                        ver = LoadVersion();
                    }
                    programVersion_loadedVersion = true;
                }
                else
                {
                    ver = myProgramVersion;
                }

                return ver;
            }

            set
            {
                myProgramVersion = value;
            }
        }

        /// <summary>
        /// Gets if the ROM has unsaved chnages and need to be saved.
        /// </summary>
        /// <returns></returns>
        public bool NeedToSave
        {
            get
            {
                return MusicList.NeedToSave || myTextGroups.Where(n => n is object && n.NeedToSave).Count() > 0 || levelIDsToReset.Any() || Levels.NeedToSave;
            }
        }

        /// <summary>
        /// Gets if the current ROM has an user created global object bank.
        /// </summary>
        /// <returns></returns>
        public bool HasGlobalObjectBank { get => GlobalModelBank is object; }

        // C o n s t r u c t o r s

        /// <summary>
        /// Creates a new instance with input ROM.
        /// </summary>
        /// <param name="FileName">The ROM that will be opened.</param>
        public RomManager(string FileName) : this(FileName, new LevelManager())
        {
        }

        /// <summary>
        /// Creates a new instance with input ROM.
        /// </summary>
        /// <param name="FileName">The ROM that will be opened.</param>
        /// <param name="levelManager">The ROM that will be opened.</param>
        public RomManager(string FileName, ILevelManager levelManager)
        {
            CustomModelConfig.RequestModel += CustomModelConfig_RequestModel;
            BehaviorConfig.RequestBehavior += BehaviorConfig_RequestBehavior;

            RomFile = FileName;
            LevelManager = levelManager;
            string levelTableFile = General.MyFilePaths["Level Tabel.json"];
            if (File.Exists(levelTableFile))
            {
                LevelInfoData.ReadFromFile(levelTableFile);
            }

            SetSegBank(0x0, 0, Conversions.ToInteger(new FileInfo(FileName).Length)); // Bank 0 means the whole ROM.
            SetSegBank(0x15, 0x2ABCA0, 0x2AC6B0);
            // SetSegBank(&H2, &H108A40, &H114750)
            SetSegBank(0x2, 0x803156, 0); // Text Table??
            LoadRomConfig();
            LoadDictionaryUpdatePatches();
        }

        // O t h e r   E v e n t s

        private void BehaviorConfig_RequestBehavior(BehaviorConfig config, BehaviorConfig.RequestBehaviorEventArgs request)
        {
            if (request.Behavior == null)
            {
                foreach (var behav in GlobalBehaviorBank.Behaviors)
                {
                    if (request.Behavior == null && behav.Config == config)
                        request.Behavior = behav;
                }
            }
        }

        private void CustomModelConfig_RequestModel(CustomModelConfig config, CustomModelConfig.RequestModelEventArgs request)
        {
            if (HasGlobalObjectBank)
                checkModelBank(GlobalModelBank);

            if (request.Model == null)
            {
                foreach (var lvl in Levels)
                {
                    if (lvl.LocalObjectBank is object)
                        checkModelBank(lvl.LocalObjectBank);
                }
            }

            void checkModelBank(CustomModelBank bank)
            {
                if (request.Model == null)
                {
                    foreach (var mdl in bank.Models)
                    {
                        if (request.Model == null && mdl.Config == config)
                            request.Model = mdl;
                    }
                }
            }
        }

        // R a i s e   E v e n t s

        private bool RaiseBeforeRomSave()
        {
            var e = new CancelEventArgs();
            BeforeRomSave?.Invoke(this, e);
            return e.Cancel;
        }

        private void RaiseAfterRomSave()
        {
            AfterRomSave?.Invoke(this, new EventArgs());
        }

        // F e a t u r e s

        public string GetRomConfigFilePath()
        {
            var p = Path.ChangeExtension(RomFile, ".config");
            if (!File.Exists(p))
            {
                var pOld = RomFile + ".config";
                if (File.Exists(pOld))
                    File.Move(pOld, p);
            }
            return p;
        }

        private void LoadRomConfig()
        {
            string confFile = GetRomConfigFilePath();
            if (File.Exists(confFile))
            {
                RomConfig = RomConfig.Load(confFile);
            }
            else
            {
                RomConfig = new RomConfig();
            }
        }

        private void SaveRomConfig()
        {
            RomConfig.Save(GetRomConfigFilePath());
        }

        /// <summary>
        /// Gets if Update Patches are avaiable for this ROM.
        /// </summary>
        /// <returns></returns>
        public bool AreRomUpdatesAvaiable()
        {
            return dicUpdatePatches.Where(n => n.Value > ProgramVersion).Count() > 0;
        }

        private void LoadDictionaryUpdatePatches()
        {
            string udatePatchsFile = General.MyFilePaths["Update-Patches.json"];
            string jsFile;
            JObject obj;
            if (File.Exists(udatePatchsFile))
            {
                jsFile = File.ReadAllText(udatePatchsFile);
                obj = JObject.Parse(jsFile);
                dicUpdatePatches = (Dictionary<string, RomVersion>)obj.ToObject(typeof(Dictionary<string, RomVersion>));
            }
        }

        /// <summary>
        /// Gets or sets the Game Name which is used for the EEP-ROM (Save file).
        /// </summary>
        /// <returns></returns>
        public string GameName
        {
            get
            {
                if (myGameName is null)
                {
                    var fs = new BinaryRom(this, FileAccess.Read);
                    fs.Position = 0x20;
                    myGameName = Encoding.ASCII.GetString(fs.Read(0x14)).Trim();
                    fs.Close();
                }

                return myGameName;
            }

            set
            {
                var fs = new BinaryRom(this, FileAccess.Write);
                fs.Position = 0x20;
                foreach (byte b in Encoding.ASCII.GetBytes(value))
                    fs.Write(b);
                while (fs.Position < 0x34)
                    fs.WriteByte(0x20);
                fs.Close();
                myGameName = value;
            }
        }

        /// <summary>
        /// Gets a new instance of BinaryRom, a BinaryData object.
        /// </summary>
        /// <param name="access"></param>
        /// <returns></returns>
        public BinaryRom GetBinaryRom(FileAccess access)
        {
            return new BinaryRom(this, access);
        }

        public RomSpaceInfo GetRomSpaceInfo()
        {
            var info = new RomSpaceInfo();
            info.MaxAvailableSpace = 0x4000000 - 0x1210000;
            info.UsedLevelsSpace = Levels.Length;
            info.UsedMusicSpace = MusicList.Length;
            info.UsedGlobalBehaviorSpace = GlobalBehaviorBank.Length;
            info.UsedGlobalModelsSpace = GlobalModelBank is object ? GlobalModelBank.Length : 0;
            return info;
        }

        public void LoadRom()
        {
            BeginLoadingRom?.Invoke(this, new EventArgs());

            // Load Global Custom Asm Bank
            LoadGlobalCustomAsmBank();

            // Load Global Behavior Bank
            LoadGlobalBehaviorBank();

            // Global Object Banks
            LoadGlobalModelBank();

            // Levels
            LoadLevels();
            
            // Music
            LoadMusic();

            AfterRomLoaded?.Invoke(this, new EventArgs());
        }

        /// <summary>
        /// Saves the ROM.
        /// </summary>
        /// <param name="IgnoreNeedToSave">If True, everything will be saved even if there are no changes.</param>
        /// <param name="DontPatchUpdates">If True, Update Patches will be ignored.</param>
        /// <param name="recalcChecksumBehavior"></param>
        public void SaveRom(bool IgnoreNeedToSave = false, bool DontPatchUpdates = false, RecalcChecksumBehavior recalcChecksumBehavior = RecalcChecksumBehavior.Auto)
        {
            if (!RaiseBeforeRomSave())
            {
                bool needUpdateChecksum = MusicList.NeedToSaveMusicHackSettings;
                if (!DontPatchUpdates)
                {
                    // Patch update-patches
                    foreach (KeyValuePair<string, RomVersion> kvp in dicUpdatePatches.Where(n => n.Value > ProgramVersion).OrderBy(n => n.Key))
                    {
                        General.PatchClass.ApplyPPF(RomFile, Path.Combine(General.MyFilePaths["Update Patches Folder"], kvp.Value.Filename));
                        needUpdateChecksum = true;
                    }
                }

                // Write Version
                WriteNewVersion();

                // Texts
                SaveAllTextGroups(ref needUpdateChecksum);

                // Music
                var lastpos = default(int);
                MusicList.Write(this, ref lastpos);
                General.HexRoundUp2(ref lastpos);

                // Global Model Bank
                SaveGlobalModelBank(ref lastpos, ref needUpdateChecksum);
                General.HexRoundUp2(ref lastpos);

                // Calc behavior bank addresses
                CalculateGlobalBehaviorBankAddresses();

                // Levels
                SaveLevels(ref lastpos); // If IgnoreNeedToSave OrElse Levels.NeedToSave Then

                // Custom Object Combos
                CustomObjects.TakeoverProperties(this);

                // Global Asm Bank
                GlobalCustomAsmBank.Save(this);

                // Global Behavior Bank
                if (RomConfig.GlobalBehaviorBank.Enabled)
                {
                    SaveGlobalBehaviorBank(ref lastpos);
                    General.HexRoundUp2(ref lastpos);
                }

                // Update checksum
                if (recalcChecksumBehavior == RecalcChecksumBehavior.Always || (recalcChecksumBehavior == RecalcChecksumBehavior.Auto && needUpdateChecksum))
                    General.PatchClass.UpdateChecksum(RomFile);

                // Write Rom.config
                SaveRomConfig();

                IsNewROM = false;
                RaiseAfterRomSave();
            }
        }

        public void CalculateGlobalBehaviorBankAddresses()
        {
            GlobalBehaviorBank.CalculateBehaviorBankAddresses(0x13000000, this);
        }

        public void DisableGlobalBehaviorBank()
        {
            if (GlobalBehaviorBank.Config.Enabled)
            {
                // Reset Pointers
                var rom = GetBinaryRom(FileAccess.ReadWrite);
                rom.Position = 0x2ABCD4;
                rom.Write(0x219E00);
                rom.Write(0x21F4C0);
                rom.Close();

                // Set enabled false
                GlobalBehaviorBank.Config.Disable();
            }
        }

        private void WriteNewVersion()
        {
            var romVerEventArgs = new RomVersionEventArgs(ProgramVersion);
            WritingNewProgramVersion?.Invoke(this, romVerEventArgs);
            WriteVersion(romVerEventArgs.RomVersion);
        }

        private void WriteVersion(RomVersion newVersion)
        {
            myProgramVersion = newVersion;
            var fs = new BinaryRom(this, FileAccess.ReadWrite);
            fs.Position = 0x1201FF8;
            fs.Write(newVersion.DevelopmentStage << 24 | newVersion.DevelopmentBuild);
            fs.WriteByte(Conversions.ToByte(newVersion.Version.Major));
            fs.WriteByte(Conversions.ToByte(newVersion.Version.Minor));
            fs.WriteByte(Conversions.ToByte(newVersion.Version.Build));
            fs.WriteByte(Conversions.ToByte(newVersion.Version.Revision));
            fs.Close();
        }

        private RomVersion LoadVersion()
        {
            var fs = new BinaryRom(this, FileAccess.Read);
            fs.Position = 0x1201FF8;
            int devInfo = fs.ReadInt32();
            byte major = fs.ReadByte();
            byte minor = fs.ReadByte();
            byte build = fs.ReadByte();
            byte revision = fs.ReadByte();
            fs.Close();
            myProgramVersion.Version = new Version(major, minor, build, revision);
            if (devInfo != 0x1010101)
            {
                myProgramVersion.DevelopmentStage = devInfo >> 24;
                myProgramVersion.DevelopmentBuild = devInfo & 0xFFFFFF;
            }
            else
            {
                myProgramVersion.DevelopmentStage = 3;
                myProgramVersion.DevelopmentBuild = 0;
            }

            return myProgramVersion;
        }

        private Text.Profiles.TextGroupInfo GetTextProfile(string name)
        {
            return TextInfoProfile.GetGroup(name);
        }

        /// <summary>
        /// Removes all loaded text groups, so they can be re-loaded.
        /// </summary>
        public void ClearTextGroups()
        {
            myTextGroups.Clear();
        }

        /// <summary>
        /// Loads the Text Tables.
        /// </summary>
        public Text.TextGroup LoadTextGroup(string name, bool CheckIfAlreadyLoaded = true)
        {
            return LoadTextGroup(myTextGroups.FirstOrDefault(n => (n.TextGroupInfo.Name ?? "") == (name ?? "")), name, CheckIfAlreadyLoaded);
        }

        private Text.TextGroup LoadTextGroup(Text.TextGroup table, string name, bool CheckIfAlreadyLoaded = true)
        {
            if (table is null || !CheckIfAlreadyLoaded)
            {
                var data = new BinaryRom(this, FileAccess.Read);
                var prof = GetTextProfile(name);
                if (table is object)
                {
                    myTextGroups.Remove(table);
                }

                if (prof is Text.Profiles.TextTableGroupInfo)
                {
                    table = new Text.TextTableGroup((Text.Profiles.TextTableGroupInfo)prof);
                }
                else if (prof is Text.Profiles.TextArrayGroupInfo)
                {
                    table = new Text.TextArrayGroup((Text.Profiles.TextArrayGroupInfo)prof);
                }

                myTextGroups.Add(table);
                table.Read(data);
                data.Close();
            }

            return table;
        }

        /// <summary>
        /// Gets the all known text sections
        /// </summary>
        /// <returns></returns>
        public Text.Profiles.TextGroupInfo[] GetTextGroupInfos()
        {
            return TextInfoProfile.AllGroups.ToArray();
        }

        /// <summary>
        /// Saves the Text Tables.
        /// </summary>
        /// <param name="table">The text table to save.</param>
        public void SaveTextGroup(Text.TextGroup table)
        {
            bool argneedUpdateChecksum = default;
            SaveTextGroup(ref argneedUpdateChecksum, table);
        }

        /// <summary>
        /// Saves the Text Tables.
        /// </summary>
        /// <param name="needUpdateChecksum">Outputs if the checksumarea was changed and need to be updated.</param>
        /// <param name="table">The text table to save.</param>
        public void SaveTextGroup(ref bool needUpdateChecksum, Text.TextGroup table)
        {
            var data = new BinaryRom(this, FileAccess.ReadWrite);
            var prof = table.TextGroupInfo;
            table.Save(data);
            table.NeedToSave = false;
            if (prof is Text.Profiles.TextTableGroupInfo)
            {
                needUpdateChecksum = needUpdateChecksum | ((Text.Profiles.TextTableGroupInfo)prof).Segmented.BankAddress == 0x80245000U;
            }
            else if (prof is Text.Profiles.TextArrayGroupInfo)
            {
                foreach (Text.Profiles.TextArrayItemInfo t in ((Text.Profiles.TextArrayGroupInfo)prof).Texts)
                {
                    // If t.RomAddress > &H20 AndAlso t.RomAddress < &H55555 Then
                    // needUpdateChecksum = True
                    // End If
                }
            }

            data.Close();
        }

        /// <summary>
        /// Saves all Text Tables.
        /// </summary>
        /// <param name="IgnoreNeedToSave">If True, everything will be saved even if there are no changes.</param>
        public void SaveAllTextGroups(bool IgnoreNeedToSave = false)
        {
            bool argneedUpdateChecksum = default;
            SaveAllTextGroups(ref argneedUpdateChecksum);
        }

        /// <summary>
        /// Saves all Text Tables.
        /// </summary>
        /// <param name="needUpdateChecksum">Outputs if the checksumarea was changed and need to be updated.</param>
        /// <param name="IgnoreNeedToSave">If True, everything will be saved even if there are no changes.</param>
        public void SaveAllTextGroups(ref bool needUpdateChecksum, bool IgnoreNeedToSave = false)
        {
            foreach (Text.TextGroup table in myTextGroups)
            {
                if (IgnoreNeedToSave || table.NeedToSave)
                {
                    SaveTextGroup(ref needUpdateChecksum, table);
                }
            }
        }

        /// <summary>
        /// Loads all Levels that are in the ROM.
        /// </summary>
        public void LoadLevels()
        {
            Levels.Clear();
            var seg0x15 = GetSegBank(0x15);
            seg0x15.ReadDataIfNull(RomFile);
            var br = new BinaryReader(seg0x15.Data);
            foreach (var ldi in LevelInfoData)
            {
                Level lvl;
                seg0x15.Data.Position = seg0x15.BankOffsetFromRomAddr((int)(ldi.Pointer + (long)3));
                byte segID = br.ReadByte();
                var curLvlSeg = SetSegBank(segID, Conversions.ToInteger(SwapInts.SwapUInt32(br.ReadUInt32())), Conversions.ToInteger(SwapInts.SwapUInt32(br.ReadUInt32())));
                uint offset = SwapInts.SwapUInt32(br.ReadUInt32());
#if !DEBUG
                try
                {
#endif
                switch (segID)
                {
                    case 0x19:
                        if (IsSM64EditorMode)
                            lvl = new SM64ELevel(ldi.ID, ldi.Index);
                        else
                            lvl = new RMLevel(RomConfig.GetLevelConfig(ldi.ID));
                        LevelManager.LoadLevel(lvl, this, ldi.ID, offset);
                        lvl.LastRomOffset = curLvlSeg.RomStart; // Original Level
                        break;
                    default:
                        lvl = null;
                        // Dim mgr As New OriginalLevelManager
                        // lvl = New OriginalLevel
                        // mgr.LoadLevel(lvl, Me, ldi.ID, offset)
                        break;
                }
#if !DEBUG
                }
                catch (Exception)
                {
                    lvl = null;
                }
#endif

                if (lvl is object)
                    Levels.Add(lvl);
            }

            AfterLevelsLoaded?.Invoke(this, new EventArgs());
        }

        /// <summary>
        /// Saves all Levels to the ROM.
        /// </summary>
        /// <param name="lastpos">At this position the Levels will be written in ROM.</param>
        public void SaveLevels(ref int lastpos)
        {
            uint curOff = Conversions.ToUInteger(lastpos);
            var binRom = new BinaryRom(this, FileAccess.ReadWrite) { Position = curOff };
            foreach (Level lvl in Levels)
            {
                var res = LevelManager.SaveLevel(lvl, this, binRom, ref curOff);
                lvl.LastRomOffset = res.Bank0x19.RomStart;
                lvl.NeedToSaveBanks0E = false;
                lvl.NeedToSaveLevelscript = false;
                General.HexRoundUp2(ref curOff);
                lastpos = (int)curOff;
            }

            binRom.Close();
            ResetListedLevelPointers();
        }

        private void ResetListedLevelPointers()
        {
            foreach (ushort id in levelIDsToReset.ToArray())
            {
                if (!Levels.Where(n => n.LevelID == id).Any())
                {
                    ResetLevelPointer(Conversions.ToByte(id));
                }

                levelIDsToReset.Remove(id);
            }
        }

        /// <summary>
        /// Loads the global object bank, if avaiable (WIP)
        /// </summary>
        public void LoadGlobalModelBank()
        {
            var fs = new BinaryRom(this, FileAccess.Read);

            // Read Bank Addres & Length from Rom
            fs.Position = 0x120FFF0;
            var seg = new SegmentedBank(0x7);
            seg.RomStart = fs.ReadInt32();
            seg.RomEnd = fs.ReadInt32();
            if (seg.RomStart != 0x1010101 && seg.RomStart > -1)
            {
                // Set Segmented Bank
                SetSegBank(seg);

                // Load Object Bank
                GlobalModelBank = new CustomModelBank();
                GlobalModelBank.ReadFromSeg(this, seg, RomConfig.GlobalModelBank);
            }
            else
            {
                // Set Object Bank to Null
                GlobalModelBank = null;
            }

            fs.Close();
        }

        public void CreateNewGlobalModelBank()
        {
            GlobalModelBank = new CustomModelBank();
        }

        public void GenerateGlobalObjectBank()
        {
            GenerateAndGetGlobalObjectBank();
        }

        private SegmentedBank GenerateAndGetGlobalObjectBank()
        {
            if (GlobalModelBank is null)
            {
                CreateNewGlobalModelBank();
            }

            var seg = GlobalModelBank.WriteToSeg(0x7);
            SetSegBank(seg);
            return seg;
        }

        private void SaveGlobalModelBank(ref int offset, ref bool needToRecalcChecksum)
        {
            var seg = GenerateAndGetGlobalObjectBank();

            // Write collision pointers
            GlobalModelBank.WriteCollisionPointers(this);

            // Set Segmented Bank
            seg.RomStart = offset;

            // Write Segmented Bank
            var rom = new BinaryRom(this, FileAccess.ReadWrite);
            seg.WriteData(rom.BaseStream);
            offset = Conversions.ToInteger(rom.Position);

            // Write Bank Address & Length to Rom
            rom.Position = 0x120FFF0;
            void checkAndSet(int value, ref bool needToRecalcChecksum2)
            {
                if (rom.ReadInt32() != value)
                {
                    rom.Position -= 4;
                    rom.Write(value);
                    needToRecalcChecksum2 = true;
                }
            }
            checkAndSet(seg.RomStart, ref needToRecalcChecksum);
            checkAndSet(seg.RomEnd, ref needToRecalcChecksum);
            rom.Close();
        }

        public void LoadGlobalBehaviorBank(bool enableAndLoadIfDisabled = false)
        {
            GlobalBehaviorBank = new BehaviorBank(RomConfig.GlobalBehaviorBank);

            if (!GlobalBehaviorBank.Config.Enabled && enableAndLoadIfDisabled)
            {
                RomConfig.GlobalBehaviorBank.Enable();
                LoadGlobalBehaviorBank();
            }

            if (GlobalBehaviorBank.Config.Enabled)
            {
                var rom = GetBinaryRom(FileAccess.Read);

                // Get Bank Address & Length from ROM
                rom.Position = 0x2ABCD4;
                var seg = new SegmentedBank(0x13)
                {
                    RomStart = rom.ReadInt32(),
                    RomEnd = rom.ReadInt32()
                };
                seg.ReadData(rom.BaseStream);
                rom.Close();

                // Read Behavior Bank
                if (RomConfig.GlobalBehaviorBank.IsVanilla)
                    GlobalBehaviorBank.ReadVanillaBank(seg);
                else
                    GlobalBehaviorBank.ReadBank(seg, 0);
            }
        }

        private void SaveGlobalBehaviorBank(ref int offset)
        {
            // Write Segmented Bank
            var seg = GlobalBehaviorBank.WriteToSeg(0x13, 0, this);
            SetSegBank(seg);

            // Set Segmented Bank
            seg.RomStart = offset;

            // Write Segmented Bank
            var rom = new BinaryRom(this, FileAccess.ReadWrite);
            seg.WriteData(rom.BaseStream);
            offset = Conversions.ToInteger(rom.Position);

            // Write Bank Address & Length to ROM
            rom.Position = 0x2ABCD4;
            rom.Write(seg.RomStart);
            rom.Write(seg.RomEnd);

            // Write addresses
            GlobalBehaviorBank.WriteBehaviorAddresss(rom);

            rom.Close();
            RomConfig.GlobalBehaviorBank.IsVanilla = false;
        }

        public void LoadGlobalCustomAsmBank()
        {
            GlobalCustomAsmBank = new CustomAsmBank(RomConfig.GlobalCustomAsmBank);
            GlobalCustomAsmBank.Load(this);
        }

        /// <summary>
        /// Creates and adds a new Level with ID.
        /// </summary>
        /// <param name="LevelID">The ID of the Level.</param>
        public Level AddLevel(byte LevelID)
        {
            var newLevel = new RMLevel(LevelID, LevelInfoData.GetByLevelID(LevelID).Index); // GetLevelIndexFromID(LevelID)
            Levels.Add(newLevel);
            if (levelIDsToReset.Contains(LevelID))
            {
                levelIDsToReset.Remove(LevelID);
            }

            return newLevel;
        }

        /// <summary>
        /// Removes a Level from the list and ROM.
        /// </summary>
        /// <param name="level">The level to remove.</param>
        public void RemoveLevel(Level level)
        {
            Levels.Remove(level);
            levelIDsToReset.Add(level.LevelID);
        }

        /// <summary>
        /// Changes the Level ID from a existing Level.
        /// </summary>
        /// <param name="level">The Level where to change the Level ID.</param>
        /// <param name="newLevelID">The new Level ID.</param>
        /// <param name="EnableActSelector">Activate/Deactivate the Act Selector fot the Level.</param>
        public bool ChangeLevelID(Level level, ushort newLevelID, bool? EnableActSelector = default)
        {
            if (level.LevelID != newLevelID)
            {
                levelIDsToReset.Add(level.LevelID);
                level.LevelID = newLevelID;
                if (EnableActSelector is object)
                    level.ActSelector = EnableActSelector == true;
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Loads the Music from the ROM.
        /// </summary>
        private void LoadMusic()
        {
            BeginLoadingMusic?.Invoke(this, new EventArgs());
            MusicList.Read(this);
            AfterMusicLoaded?.Invoke(this, new EventArgs());
        }

        /// <summary>
        /// Check, if the ROM is a valid SM64 ROM.
        /// </summary>
        /// <returns></returns>
        public bool CheckROM()
        {
            var fi = new FileInfo(RomFile);
            long filelength = fi.Length;
            if (fi.IsReadOnly)
            {
                throw new ReadOnlyException("This ROM file is Read-Only. Remove the write protection and try again.");
            }

            if (filelength == 8 * 1024 * 1024)
            {
                CreateROM();
                PrepairROM();
                IsNewROM = true;
            }

            var br = new BinaryRom(this, FileAccess.Read);
            br.Position = 0x1200000;
            long tCheckData = br.ReadInt64();
            br.Close();
            IsSM64EditorMode = new[] { 0x800800001900001C, 0x800800000E0000C4 }.Contains((ulong)tCheckData);
            if (IsSM64EditorMode && LevelManager is LevelManager)
            {
                LevelManager = new SM64EditorLevelManager();
            }

            return true;
        }

        private void PrepairROM()
        {
            // Patch things
            var proc = new Process();
            {
                proc.StartInfo.FileName = General.MyFilePaths["ApplyPPF3.exe"];
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.Arguments = string.Format("a \"{0}\" \"{1}\"", RomFile, General.MyFilePaths["SM64_ROM_Manager.ppf"]);
                proc.StartInfo.CreateNoWindow = true;
            }
            proc.Start();
            proc.WaitForExit();

            var fs = new BinaryRom(this, FileAccess.ReadWrite);

            // Write Custom Background Pointer
            fs.Position = 0x1202500;
            foreach (string s in "0A 02 00 00 0A 01 88 00 0A 02 00 00 0A 02 00 00 0A 02 00 00 0A 02 00 00 0A 01 48 00 0A 02 00 00 0A 01 48 00 0A 02 00 00 0A 02 00 00".Split(' '))
                fs.WriteByte(Conversions.ToByte("&H" + s));

            // Patch Act-Selector
            General.PatchClass.Open(fs);
            General.PatchClass.ActSelector_ApplyPatch();

            // Hardcoded Camera Settings
            General.PatchClass.HardcodedCamera_ApplyPatch();
            General.PatchClass.HardcodedCamera_DisableAll();

            // Restore Checksum Check
            General.PatchClass.RestoreChecksum();
            fs.Close();

            // Repaire patched music
            MusicList.Read(this);
            MusicList.NeedToSaveSequences = true;
            MusicList.NeedToSaveSequenceNames = true;
            MusicList.NeedToSaveNInsts = true;
            MusicList.NeedToSaveMusicHackSettings = true;
            int arglastPosition = 0;
            MusicList.Write(this, ref arglastPosition);

            // Update Checksum
            General.PatchClass.UpdateChecksum(RomFile);

            WriteNewVersion();
            SaveRomConfig();
        }

        /// <summary>
        /// Extens the ROM.
        /// </summary>
        /// <param name="IsSecondTry">If True, no new try will be executed, if failed.</param>
        public void CreateROM(bool IsSecondTry = false)
        {
            // Check md5 hash of ROM
            if (!IsSecondTry)
            {
                var md5 = General.ComputeMD5Hash(RomFile);
                if (md5 != SUPER_MARIO_64_U_MD5HASH)
                    throw new InvalidMD5HashException();
            }

            // Extend to 64MB
            var proc = new Process();
            {
                var withBlock = proc.StartInfo;
                withBlock.FileName = General.MyFilePaths["sm64extend.exe"];
                withBlock.UseShellExecute = false;
                withBlock.Arguments = string.Format("-a 16 -f \"{0}\" \"{0}\"", RomFile);
                withBlock.CreateNoWindow = true;
            }

            proc.Start();
            proc.WaitForExit();

            //if (new FileInfo(RomFile).Length == 8 * 1024 * 1024)
            //{
            //    if (IsSecondTry)
            //    {
            //        throw new Exception("Your ROM is invalid, it isn't possible to extend it.");
            //    }
            //    else
            //    {
            //        var fs = new BinaryRom(this, FileAccess.Write);
            //        fs.Position = 0x10;
            //        foreach (string b in "63 5A 2B FF 8B 02 23 26".Split(' '))
            //            fs.WriteByte(Conversions.ToByte("&H" + b));
            //        fs.Close();
            //        CreateROM(true);
            //    }
            //}
        }

        /// <summary>
        /// Resets the Level Pointer of the Level with the given ID.
        /// </summary>
        /// <param name="ID">The ID where to reset the pointer.</param>
        public void ResetLevelPointer(byte ID)
        {
            ResetLevelPointer(LevelInfoData.GetByLevelID(ID));
        }

        /// <summary>
        /// Resets the Level Pointer of the Level with the given Levelinfo.
        /// </summary>
        /// <param name="info">The Levelinfo where to reset the pointer.</param>
        public void ResetLevelPointer(LevelInfoDataTabelList.Level info)
        {
            var fsPointer = new BinaryFile(Path.Combine(General.MyFilePaths["Original Level Pointers.bin"]), FileMode.Open, FileAccess.Read);
            var fsRom = new BinaryRom(this, FileAccess.ReadWrite);
            var data = new byte[20];
            fsPointer.Position = info.Pointer - (long)0x2AC094;
            fsPointer.Read(data, 0, data.Count());
            fsRom.Position = info.Pointer;
            fsRom.Write(data);
            fsPointer.Close();
            fsRom.Close();
        }

        public SegmentedBank SetSegBank(byte BankID, int RomStart, int RomEnd)
        {
            return SetSegBank(BankID, RomStart, RomEnd, default);
        }

        public SegmentedBank SetSegBank(byte BankID, int RomStart, int RomEnd, byte? AreaID)
        {
            var newBank = new SegmentedBank() { BankID = BankID, RomStart = RomStart, RomEnd = RomEnd };
            SetSegBank(newBank, AreaID);
            return newBank;
        }

        public void SetSegBank(SegmentedBank SegBank)
        {
            SetSegBank(SegBank, default);
        }

        public void SetSegBank(SegmentedBank SegBank, byte? AreaID)
        {
            Dictionary<byte, SegmentedBank> sbl;
            if (AreaID is object)
            {
                if (areaSegBankList.ContainsKey((byte)AreaID))
                {
                    sbl = areaSegBankList[(byte)AreaID];
                }
                else
                {
                    sbl = new Dictionary<byte, SegmentedBank>();
                    areaSegBankList.Add((byte)AreaID, sbl);
                }
            }
            else
            {
                sbl = segBankList;
            }

            if (sbl.ContainsKey(SegBank.BankID))
            {
                sbl.Remove(SegBank.BankID);
            }

            sbl.Add(SegBank.BankID, SegBank);
        }

        public SegmentedBank GetSegBank(byte BankID)
        {
            return GetSegBank(BankID, default);
        }

        public SegmentedBank GetSegBank(byte BankID, byte? AreaID)
        {
            if (AreaID is object && areaSegBankList.ContainsKey((byte)AreaID) && areaSegBankList[(byte)AreaID].ContainsKey(BankID))
            {
                return areaSegBankList[(byte)AreaID][BankID];
            }
            else if (segBankList.ContainsKey(BankID))
            {
                return segBankList[BankID];
            }
            else
            {
                return null;
            }
        }

        public SegmentedBank[] GetAllSegBanks()
        {
            var sb = new List<SegmentedBank>();
            foreach (var kvp in segBankList)
                sb.Add(kvp.Value);
            return sb.ToArray();
        }

        public BinaryData GetSegBankData(byte bankID)
        {
            BinaryData data;

            // Get correct bank
            var seg = GetSegBank(bankID);
            seg.ReadDataIfNull(this);
            data = new BinaryStreamData(seg.Data);

            return data;
        }

    }
}