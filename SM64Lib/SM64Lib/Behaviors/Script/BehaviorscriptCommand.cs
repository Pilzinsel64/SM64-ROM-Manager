
using Newtonsoft.Json;
using SM64Lib.Json;

namespace SM64Lib.Behaviors.Script
{
    [JsonConverter(typeof(BehaviorscriptCommandJsonConverter))]
    public class BehaviorscriptCommand : SM64Lib.Script.BaseCommand<BehaviorscriptCommandTypes>
    {

        public override BehaviorscriptCommandTypes CommandType
        {
            get
            {
                Position = 0;
                return (BehaviorscriptCommandTypes)ReadByte();
            }

            set
            {
                Position = 0;
                WriteByte((byte)value);
            }
        }

        public BehaviorscriptCommand() : base()
        {
        }

        public BehaviorscriptCommand(byte[] cmd) : base(cmd)
        {
        }

        public BehaviorscriptCommand(string cmd) : base(cmd, true)
        {
        }

        public static int GetCommandLength(BehaviorscriptCommandTypes type)
        {
            switch (type)
            {
                case BehaviorscriptCommandTypes.x00_Start: return 4;
                case BehaviorscriptCommandTypes.x01_StateLoop: return 4;
                case BehaviorscriptCommandTypes.x02_JumpandLink: return 8;
                case BehaviorscriptCommandTypes.x03_Return: return 4;
                case BehaviorscriptCommandTypes.x04_Jump: return 8;
                case BehaviorscriptCommandTypes.x05_LoopN: return 4;
                case BehaviorscriptCommandTypes.x06_EndLoopN: return 4;
                case BehaviorscriptCommandTypes.x07_InfiniteLoop: return 4;
                case BehaviorscriptCommandTypes.x08_LoopStart: return 4;
                case BehaviorscriptCommandTypes.x09_LoopEnd: return 4;
                case BehaviorscriptCommandTypes.x0A_EndBehaviorscript: return 4;
                case BehaviorscriptCommandTypes.x0B_EndBehaviorscript_Unused: return 4;
                case BehaviorscriptCommandTypes.x0C_CallFunction: return 8;
                case BehaviorscriptCommandTypes.x0D_OffsetbyFloat: return 4;
                case BehaviorscriptCommandTypes.x0E_SettoFloat: return 4;
                case BehaviorscriptCommandTypes.x0F_OffsetbyInteger: return 4;
                case BehaviorscriptCommandTypes.x10_SettoInteger: return 4;
                case BehaviorscriptCommandTypes.x11_BitSet: return 4;
                case BehaviorscriptCommandTypes.x12_BitClear: return 4;
                case BehaviorscriptCommandTypes.x13_AddRNG: return 8;
                case BehaviorscriptCommandTypes.x14_ObjectType: return 8;
                case BehaviorscriptCommandTypes.x15_FloatMultiply: return 8;
                case BehaviorscriptCommandTypes.x16_FloatAdd: return 8;
                case BehaviorscriptCommandTypes.x17_AddRNG2: return 8;
                case BehaviorscriptCommandTypes.x18_NoOperation: return 4;
                case BehaviorscriptCommandTypes.x19_NoOperation: return 4;
                case BehaviorscriptCommandTypes.x1A_NoOperation: return 4;
                case BehaviorscriptCommandTypes.x1B_ChangeModelID: return 4;
                case BehaviorscriptCommandTypes.x1C_LoadChildObject: return 0xC;
                case BehaviorscriptCommandTypes.x1D_Deactivate: return 4;
                case BehaviorscriptCommandTypes.x1E_DroptoGround: return 4;
                case BehaviorscriptCommandTypes.x1F_UsedforWaves: return 4;
                case BehaviorscriptCommandTypes.x20_Unused: return 4;
                case BehaviorscriptCommandTypes.x21_SetBillboarding: return 4;
                case BehaviorscriptCommandTypes.x22_SetRenderInvisibleflag: return 4;
                case BehaviorscriptCommandTypes.x23_Collisioncylindersize: return 8;
                case BehaviorscriptCommandTypes.x24_Nothing: return 4;
                case BehaviorscriptCommandTypes.x25_StateCycle: return 4;
                case BehaviorscriptCommandTypes.x26_Loop: return 4;
                case BehaviorscriptCommandTypes.x27_SetWord: return 8;
                case BehaviorscriptCommandTypes.x28_Animates: return 4;
                case BehaviorscriptCommandTypes.x29_LoadChildObject: return 0xC;
                case BehaviorscriptCommandTypes.x2A_SetCollision: return 8;
                case BehaviorscriptCommandTypes.x2B_SetCollisionSphere: return 0xC;
                case BehaviorscriptCommandTypes.x2C_SpawnObject: return 0xC;
                case BehaviorscriptCommandTypes.x2D_SetInitPosition: return 4;
                case BehaviorscriptCommandTypes.x2E_SetHurtbox: return 8;
                case BehaviorscriptCommandTypes.x2F_SetInteraction: return 8;
                case BehaviorscriptCommandTypes.x30_SetGravity: return 0x14;
                case BehaviorscriptCommandTypes.x31_SetInteractionSubType: return 8;
                case BehaviorscriptCommandTypes.x32_ScaleObject: return 4;
                case BehaviorscriptCommandTypes.x33_ChildObjectChange: return 8;
                case BehaviorscriptCommandTypes.x34_TextureAnimateRate: return 4;
                case BehaviorscriptCommandTypes.x35_ClearGraphFlag: return 4;
                case BehaviorscriptCommandTypes.x36_SetValue: return 8;
                case BehaviorscriptCommandTypes.x37_SpawnSomething: return 8;
                default: return -1; //throw new System.Exception("Command type not found!");
            }
        }

        public static bool IsEndCommand(BehaviorscriptCommandTypes type)
        {
            switch (type)
            {
                case BehaviorscriptCommandTypes.x02_JumpandLink:
                case BehaviorscriptCommandTypes.x04_Jump:
                case BehaviorscriptCommandTypes.x06_EndLoopN:
                case BehaviorscriptCommandTypes.x0A_EndBehaviorscript:
                case BehaviorscriptCommandTypes.x0B_EndBehaviorscript_Unused:
                case BehaviorscriptCommandTypes.x09_LoopEnd:
                    return true;
                default:
                    return false;
            }
        }

    }
}