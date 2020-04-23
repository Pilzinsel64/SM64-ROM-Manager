using Newtonsoft.Json;
using SM64Lib.Behaviors.Script;
using SM64Lib.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.Behaviors
{
    public class Behavior
    {
        [JsonProperty]
        public BehaviorConfig Config { get; private set; }
        public Behaviorscript Script { get; private set; }
        public int CollisionPointer { get; set; }
        public bool EnableCollisionPointer { get; set; }
        public List<int> BehaviorAddressDestinations { get; set; } = new List<int>();

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
            EnableCollisionPointer = false;

            foreach (BehaviorscriptCommand cmd in Script)
            {
                switch (cmd.CommandType)
                {
                    case BehaviorscriptCommandTypes.x2A_SetCollision:
                        CollisionPointer = BehaviorscriptCommandFunctions.X2A.GetCollisionPointer(cmd);
                        EnableCollisionPointer = true;
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
