using Newtonsoft.Json;
using SM64Lib.ASM;
using SM64Lib.Behaviors.Script;
using SM64Lib.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Z.Collections.Extensions;

namespace SM64Lib.Behaviors
{
    public class Behavior
    {
        private readonly Dictionary<CustomAsmArea, BehaviorscriptCommand> knownCustomAsmCommands = new Dictionary<CustomAsmArea, BehaviorscriptCommand>();

        [JsonProperty]
        public BehaviorConfig Config { get; private set; }
        public Behaviorscript Script { get; private set; }
        public int CollisionPointer { get; set; }
        public bool EnableCollisionPointer { get; set; }
        public List<int> BehaviorAddressDestinations { get; set; } = new List<int>();

        [JsonIgnore]
        public long Length
        {
            get
            {
                if (Config.FixedLength == -1)
                    return Script.Length;
                else
                    return Config.FixedLength;
            }
        }

        public Behavior() : this(new BehaviorConfig())
        {
        }

        public Behavior(BehaviorConfig config)
        {
            CreateNewBehaviorscript();
            Config = config;
        }

        public Behavior(BehaviorCreationTypes behaviorCreationType) : this()
        {
            Create(behaviorCreationType);
        }

        public void Create(BehaviorCreationTypes type)
        {
            CreateNewBehaviorscript();

            switch (type)
            {
                case BehaviorCreationTypes.SolidObject:
                    Script.Add(new BehaviorscriptCommand("00 09 00 00"));
                    Script.Add(new BehaviorscriptCommand("2a 00 00 00 00 00 00 00"));
                    Script.Add(new BehaviorscriptCommand("08 00 00 00"));
                    Script.Add(new BehaviorscriptCommand("0c 00 00 00 80 38 39 cc"));
                    Script.Add(new BehaviorscriptCommand("09 00 00 00"));
                    break;
            }

            ParseScript();
        }

        private void CreateNewBehaviorscript()
        {
            if (Script != null)
                Script.Close();
            Script = new Behaviorscript();
        }

        public void Read(BinaryData data, int address)
        {
            Read(data, address, false);
        }

        public bool Read(BinaryData data, int address, bool setFixedSize)
        {
            CreateNewBehaviorscript();
            var success = Script.Read(data, address);
            if (setFixedSize)
                Config.FixedLength = (int)Script.Length;
            ParseScript();
            return success;
        }

        public void Write(BinaryData data, int address)
        {
            //if (!Config.IsVanilla)
            TakeoverSettingsToScript();

            var length = Script.Write(data, address);

            if (Config.FixedLength != -1 && length != Config.FixedLength)
                data.Position -= length - Config.FixedLength;
        }

        public void ParseScript()
        {
            var dicCustomAsmFuncs = new Dictionary<int, CustomAsmAreaLinkOptions>();
            EnableCollisionPointer = false;
            knownCustomAsmCommands.Clear();

            foreach (var link in Config.CustomAsmLinks)
                dicCustomAsmFuncs.AddOrUpdate(link.CustomAsm.Config.RamAddress | unchecked((int)0x80000000), link);

            foreach (BehaviorscriptCommand cmd in Script)
            {
                switch (cmd.CommandType)
                {
                    case BehaviorscriptCommandTypes.x2A_SetCollision:
                        CollisionPointer = BehaviorscriptCommandFunctions.X2A.GetCollisionPointer(cmd);
                        EnableCollisionPointer = true;
                        break;
                    case BehaviorscriptCommandTypes.x0C_CallFunction:
                        var ptr = BehaviorscriptCommandFunctions.X0C.GetAsmPointer(cmd);
                        if (dicCustomAsmFuncs.ContainsKey(ptr))
                            knownCustomAsmCommands.Add(dicCustomAsmFuncs[ptr].CustomAsm, cmd);
                        break;
                }
            }
        }

        public void TakeoverSettingsToScript()
        {
            // Update collision pointer
            AddUpdateRemoveCmd(
                BehaviorscriptCommandTypes.x2A_SetCollision,
                EnableCollisionPointer,
                () => BehaviorscriptCommandFactory.Build_x2A(CollisionPointer),
                (cmd) => BehaviorscriptCommandFunctions.X2A.SetCollisionPointer(cmd, CollisionPointer));

            // Insert Custom Asm Links
            {
                foreach (var link in Config.CustomAsmLinks)
                {
                    var asmPointer = link.CustomAsm.Config.RamAddress | unchecked((int)0x80000000);
                    var cmdStartLoop = Script.FirstOfType(BehaviorscriptCommandTypes.x08_LoopStart);
                    var cmdStartLoopIndex = Script.IndexOf(cmdStartLoop);
                    int iInsert;

                    if (link.Loop)
                    {
                        if (cmdStartLoop is object)
                            iInsert = cmdStartLoopIndex + 1;
                        else
                            iInsert = -1;
                    }
                    else
                    {
                        if (cmdStartLoop is object)
                            iInsert = cmdStartLoopIndex;
                        else
                            iInsert = (int)Script.Count - 2;
                    }

                    if (knownCustomAsmCommands.ContainsKey(link.CustomAsm))
                    {
                        var cmd = knownCustomAsmCommands[link.CustomAsm];
                        var cmdIndex = Script.IndexOf(cmd);
                        BehaviorscriptCommandFunctions.X0C.SetAsmPointer(cmd, asmPointer);

                        if (cmdIndex != -1)
                        {
                            var reinsert = false;

                            if (link.Loop && cmdIndex < cmdStartLoopIndex)
                            {
                                reinsert = true;
                                iInsert -= 1;
                            }
                            else if (!link.Loop && cmdIndex > cmdStartLoopIndex)
                                reinsert = true;

                            if (reinsert)
                            {
                                Script.Remove(cmd);
                                Script.Insert(iInsert, cmd);
                            }
                        }
                    }
                    else if (iInsert != -1)
                    {
                        var cmd = BehaviorscriptCommandFactory.Build_x0C(asmPointer);
                        Script.Insert(iInsert, cmd);
                        knownCustomAsmCommands.Add(link.CustomAsm, cmd);
                    }
                }

                foreach (var kvp in knownCustomAsmCommands.ToArray())
                {
                    if (!Config.CustomAsmLinks.Where(n => n.CustomAsm == kvp.Key).Any())
                    {
                        knownCustomAsmCommands.Remove(kvp.Key);
                        Script.RemoveIfContains(kvp.Value);
                        kvp.Value.Close();
                    }
                }
            }
        }

        private void AddUpdateRemoveCmd(BehaviorscriptCommandTypes cmdType, bool conditionAddUpdate, Func<BehaviorscriptCommand> createCmd, Action<BehaviorscriptCommand> updateCmd)
        {
            var cmd = Script.FirstOfType(cmdType);
            if (cmd is object)
            {
                if (conditionAddUpdate)
                    updateCmd(cmd);
                else
                {
                    Script.Remove(cmd);
                    cmd.Close();
                }
            }
            else if (conditionAddUpdate)
            {
                cmd = createCmd();
                Script.Insert(1, cmd);
            }
        }

    }
}
