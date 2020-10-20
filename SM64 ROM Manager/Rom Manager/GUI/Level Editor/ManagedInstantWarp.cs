using global::System.ComponentModel;
using global::System.Numerics;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64Lib.Levels.Script;
using global::SM64Lib.Levels.Script.Commands;

namespace SM64_ROM_Manager
{
    [DefaultProperty("CollisionType")]
    public class ManagedInstantWarp : IManagedLevelscriptCommand
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

        [DisplayName("Collision Type")]
        [Description("The collision type to use." + Constants.vbNewLine + "Only collision types from the areas 0x1B to 0x1E are allowed.")]
        [Category("Collision")]
        public byte CollisionType { get; set; } = 0x1B;
        [DisplayName("Dest. Area ID")]
        [Description("The area where the player should be warped to.")]
        [Category("Destination")]
        public byte DestAreaID { get; set; } = 0;
        [DisplayName("Amount on X-axis")]
        [Description("Teleports Mario by the specified amount on the X-axis.")]
        [Category("Location")]
        public short AmountOnXAxis { get; set; } = 0;
        [DisplayName("Amount on Y-axis")]
        [Description("Teleports Mario by the specified amount on the Y-axis.")]
        [Category("Location")]
        public short AmountOnYAxis { get; set; } = 0;
        [DisplayName("Amount on Z-axis")]
        [Description("Teleports Mario by the specified amount on the Z-axis.")]
        [Category("Location")]
        public short AmountOnZAxis { get; set; } = 0;

        public ManagedInstantWarp(LevelscriptCommand cmd)
        {
            Command = cmd;
            LoadProperties();
        }

        public void LoadProperties()
        {
            // Collision Type
            CollisionType = clInstantWarp.GetCollisionType(Command);

            // Destination Area ID
            DestAreaID = clInstantWarp.GetAreaID(Command);

            // Position
            var loc = clInstantWarp.GetLocation(Command);
            AmountOnXAxis = Conversions.ToShort(loc.X);
            AmountOnYAxis = Conversions.ToShort(loc.Y);
            AmountOnZAxis = Conversions.ToShort(loc.Z);
        }

        public void SaveProperties()
        {
            SaveProperties(Command);
        }

        public void SaveProperties(LevelscriptCommand Command)
        {
            // Collision Type
            clInstantWarp.SetCollisionType(Command, CollisionType);

            // Destination Area ID
            clInstantWarp.SetAreaID(Command, DestAreaID);

            // Position
            var loc = new Vector3(AmountOnXAxis, AmountOnYAxis, AmountOnZAxis);
            clInstantWarp.SetLocation(Command, loc);
        }
    }
}