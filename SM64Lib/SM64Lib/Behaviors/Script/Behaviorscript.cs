using SM64Lib.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SM64Lib.Behaviors.Script
{
    public class Behaviorscript : BehaviorscriptCommandCollection
    {
        public bool Read(BinaryData data, int address)
        {
            bool ende = false;
            bool success = true;
            var newCmds = new List<BehaviorscriptCommand>();
            
            data.Position = address;

            while (!ende)
            {
                // Get command infos
                var cmdType = (BehaviorscriptCommandTypes)data.ReadByte();
                int cmdLength = BehaviorscriptCommand.GetCommandLength(cmdType);
                var unknownCmd = cmdLength == -1;
                bool isEndCmd = unknownCmd || BehaviorscriptCommand.IsEndCommand(cmdType);

                if (!unknownCmd)
                {
                    // Reset position
                    data.Position -= 1;

                    // Read full command
                    byte[] buf = new byte[cmdLength];
                    data.Read(buf);

                    // Create & add command
                    try
                    {
                        newCmds.Add(new BehaviorscriptCommand(buf));
                    }
                    catch (Exception)
                    {
                        success = false;
                    }
                }
                else
                    data.Position += 3;

                ende = isEndCmd;
            }

            // Add new Cmds
            if (success && newCmds.Any())
            {
                Close();
                AddRange(newCmds.ToArray());
            }

            return success;
        }

        public int Write(BinaryData data, int address)
        {
            data.Position = address;

            foreach (BehaviorscriptCommand command in this)
            {
                var cmdLength = BehaviorscriptCommand.GetCommandLength(command.CommandType);
                if (command.Length != cmdLength)
                    command.SetLength(cmdLength);
                data.Write(command.ToArray());
            }

            return (int)data.Position - address;
        }

        public int IndexOfType(BehaviorscriptCommandTypes cmdType)
        {
            return IndexOf(this.FirstOrDefault(n => n.CommandType == cmdType));
        }

        public BehaviorscriptCommand FirstOfType(BehaviorscriptCommandTypes cmdType)
        {
            return (BehaviorscriptCommand)this.FirstOrDefault(n => n.CommandType == cmdType);
        }

    }
}