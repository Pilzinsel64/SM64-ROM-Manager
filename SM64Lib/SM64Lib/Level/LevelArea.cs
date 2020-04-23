using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64Lib.Levels.Script;
using global::SM64Lib.Levels.Script.Commands;
using global::SM64Lib.Levels.ScrolTex;
using global::SM64Lib.Model;

namespace SM64Lib.Levels
{
    public abstract class LevelArea
    {

        // S h a r e d   M e m b e r s

        public static readonly byte[] DefaultNormal3DObject = new byte[] { 0x24, 0x18, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x13, 0x0, 0x0, 0x0 };

        // F i e l d s

        protected bool _GettingAreaCollision = false;

        // A u t o   P r o p e r t i e s

        public SpecialBoxList SpecialBoxes { get; private set; } = new SpecialBoxList();
        public List<ManagedScrollingTexture> ScrollingTextures { get; private set; } = new List<ManagedScrollingTexture>();
        public List<LevelscriptCommand> Objects { get; private set; } = new List<LevelscriptCommand>();
        public List<LevelscriptCommand> MacroObjects { get; private set; } = new List<LevelscriptCommand>();
        public List<LevelscriptCommand> Warps { get; private set; } = new List<LevelscriptCommand>();
        public List<LevelscriptCommand> WarpsForGame { get; private set; } = new List<LevelscriptCommand>();
        public ShowMessage ShowMessage { get; private set; } = new ShowMessage();
        public AreaBG Background { get; private set; } = new AreaBG();
        public LevelscriptCommandCollection Levelscript { get; set; } = new LevelscriptCommandCollection();
        public Geolayout.Geolayout Geolayout { get; set; } = new Geolayout.Geolayout(SM64Lib.Geolayout.Geolayout.NewScriptCreationMode.None);
        public Geolayout.TerrainTypes TerrainType { get; set; } = SM64Lib.Geolayout.TerrainTypes.NoramlA;
        public byte BGMusic { get; set; } = 0;
        public byte AreaID { get; set; } = 0;
        public uint GeolayoutOffset { get; set; } = 0;
        public ObjectModel AreaModel { get; set; } = new ObjectModel();
        public bool Enable2DCamera { get; set; } = false;
        public uint Bank0x0EOffset { get; set; } = 0;
        public int Bank0xELength { get; set; }

        // O t h e r   P r o p e r t i e s

        public int Fast3DBankRomStart
        {
            get
            {
                return Conversions.ToInteger(Bank0x0EOffset);
            }
        }

        public int Fast3DLength
        {
            get
            {
                return CollisionPointer - 0xE000000;
            }
        }

        public bool IsCamera2D
        {
            get
            {
                return Enable2DCamera && Geolayout.CameraPreset == SM64Lib.Geolayout.CameraPresets.PlattfromLevels;
            }
        }

        public int CollisionPointer
        {
            get
            {
                int CollisionPointerRet = default;
                _GettingAreaCollision = true;
                foreach (var cmd in Levelscript)
                {
                    if (cmd.CommandType == LevelscriptCommandTypes.AreaCollision)
                    {
                        CollisionPointerRet = Conversions.ToInteger(clAreaCollision.GetAreaCollision((LevelscriptCommand)cmd));
                    }
                }

                _GettingAreaCollision = false;
                return CollisionPointerRet;
            }

            set
            {
                if (_GettingAreaCollision)
                    return;
                foreach (var cmd in Levelscript)
                {
                    if (cmd.CommandType == LevelscriptCommandTypes.AreaCollision)
                    {
                        clAreaCollision.SetAreaCollision((LevelscriptCommand)cmd, Conversions.ToUInteger(value));
                    }
                }
            }
        }

        // M e t h o d s

        public void SetSegmentedBanks(RomManager rommgr)
        {
            var bank0xE = rommgr.SetSegBank(0xE, Conversions.ToInteger(Bank0x0EOffset), (int)(Bank0x0EOffset + Bank0xELength), AreaID);
            bank0xE.Data = AreaModel.Fast3DBuffer;
        }

        internal void UpdateScrollingTextureVertexPointer(int offset)
        {
            foreach (ManagedScrollingTexture scrollText in ScrollingTextures)
                scrollText.VertexPointer += offset;
        }

        public void Close()
        {
            Levelscript.Close();
            Geolayout.Close();
        }

        // C o n s t r u c t o r s

        protected LevelArea(byte AreaID) : this(AreaID, 9)
        {
        }

        protected LevelArea(byte AreaID, byte LevelID) : this(AreaID, LevelID, true, true)
        {
        }

        protected LevelArea(byte AreaID, byte LevelID, bool AddWarps, bool AddObjects)
        {
            Geolayout = new Geolayout.Geolayout(SM64Lib.Geolayout.Geolayout.NewScriptCreationMode.Level);
            this.AreaID = AreaID;
            {
                var withBlock = Levelscript;
                withBlock.Add(new LevelscriptCommand(new byte[] { 0x1F, 0x8, AreaID, 0x0, 0x0, 0x0, 0x0, 0x0 }));
                withBlock.Add(new LevelscriptCommand(new byte[] { 0x2E, 0x8, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0 }));
                withBlock.Add(new LevelscriptCommand(new byte[] { 0x36, 0x8, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0 }));
                withBlock.Add(new LevelscriptCommand(new byte[] { 0x31, 0x4, 0x0, 0x2 }));
                withBlock.Add(new LevelscriptCommand(new byte[] { 0x20, 0x4, 0x0, 0x0 }));
            }

            if (AddWarps)
            {
                Objects.Add(new LevelscriptCommand(new byte[] { 0x24, 0x18, 0x1F, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0xA, 0x0, 0x0, 0x13, 0x0, 0x2F, 0x74 }));
                Warps.Add(new LevelscriptCommand(new byte[] { 0x26, 0x8, 0xA, LevelID, AreaID, 0x0, 0x0, 0x0 }));
                WarpsForGame.Add(new LevelscriptCommand(new byte[] { 0x26, 0x8, 0xF0, 0x6, 0x1, 0x32, 0x0, 0x0 }));
                WarpsForGame.Add(new LevelscriptCommand(new byte[] { 0x26, 0x8, 0xF1, 0x6, 0x1, 0x64, 0x0, 0x0 }));
            }

            if (AddObjects)
            {
                for (int i = 1; i <= 15; i++)
                {
                    var newObj = new LevelscriptCommand(DefaultNormal3DObject);
                    Objects.Add(newObj);
                }
            }
        }

        protected LevelArea()
        {
            Geolayout = new Geolayout.Geolayout(SM64Lib.Geolayout.Geolayout.NewScriptCreationMode.Level);
        }
    }
}