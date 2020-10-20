using global::System.ComponentModel;
using global::SM64Lib.Levels;
using global::SM64Lib.Levels.Script;
using global::SM64Lib.Levels.Script.Commands;

namespace SM64_ROM_Manager
{
    [DefaultProperty("WarpID")]
    public class ManagedWarp : IManagedLevelscriptCommand
    {
        [Browsable(false)]
        public LevelscriptCommand Command { get; private set; } = null;

        [ReadOnly(true)]
        [Category("Address")]
        [DisplayName("Rom Address")]
        public int RomAddress
        {
            get
            {
                return Command.RomAddress;
            }
        }

        [ReadOnly(true)]
        [Category("Address")]
        [DisplayName("Bank Address")]
        public int BankAddress
        {
            get
            {
                return Command.BankAddress;
            }
        }

        [DisplayName("Warp ID")]
        [Category("Source")]
        [Description("The source ID of the warp.")]
        public byte WarpID { get; set; }
        [DisplayName("Dest. Level")]
        [Category("Destination")]
        [Description("The level where the player should be warped to.")]
        public Levels DestLevelID { get; set; }
        [DisplayName("Dest. Area ID")]
        [Category("Destination")]
        [Description("The area where the player should be warped to.")]
        public byte DestAreaID { get; set; }
        [DisplayName("Dest. Warp ID")]
        [Category("Destination")]
        [Description("The warp ID that the player should be warped to.")]
        public byte DestWarpID { get; set; }
        [DisplayName("Create Checkpoint")]
        [Category("Destination")]
        [Description("The warp will act as a checkpoint when this is enabled. When the player re-enters this level after dying, Mario will start at this warp.")]
        public bool CreateCheckpoint { get; set; }

        public ManagedWarp(LevelscriptCommand cmd)
        {
            Command = cmd;
            LoadProperties();
        }

        public void LoadProperties()
        {
            // Warp-ID
            WarpID = clWarp.GetWarpID(Command);

            // Destination Level-ID
            DestLevelID = clWarp.GetDestinationLevelID(Command);

            // Destination Area-ID
            DestAreaID = clWarp.GetDestinationAreaID(Command);

            // Destination Warp-ID
            DestWarpID = clWarp.GetDestinationWarpID(Command);

            // Create Checkpoint
            CreateCheckpoint = clWarp.GetCreateCheckpoint(Command);
        }

        public void SaveProperties()
        {
            SaveProperties(Command);
        }

        public void SaveProperties(LevelscriptCommand Command)
        {
            // Warp-ID
            clWarp.SetWarpID(Command, WarpID);

            // Destination Level-ID
            clWarp.SetDestinationLevelID(Command, DestLevelID);

            // Destination Area-ID
            clWarp.SetDestinationAreaID(Command, DestAreaID);

            // Destination Warp-ID
            clWarp.SetDestinationWarpID(Command, DestWarpID);

            // Create Checkpoint
            clWarp.SetCreateCheckpoint(Command, CreateCheckpoint);
        }
    }
}