using Newtonsoft.Json;
using SM64Lib.Data;
using SM64Lib.SegmentedBanking;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Z.Collections.Extensions;

namespace SM64Lib.Behaviors
{
    public class BehaviorBank
    {
        public BehaviorBankConfig Config { get; private set; }
        public List<Behavior> Behaviors { get; } = new List<Behavior>();

        [JsonIgnore]
        public long Length
        {
            get => Behaviors.Sum(n => n.Length);
        }

        public BehaviorBank(BehaviorBankConfig config)
        {
            Config = config;
        }

        public void ReadBank(SegmentedBank seg, int offset)
        {
            ReadBank(seg, offset, false);
        }

        public void ReadVanillaBank(SegmentedBank seg)
        {
            ReadBank(seg, 0, true);
        }

        private void ReadBank(SegmentedBank seg, int offset, bool isVanilla)
        {
            var data = new BinaryStreamData(seg.Data);
            data.Position = offset;
            ReadBank(data, isVanilla, seg.Length, (sbyte)seg.BankID);
        }

        public void ReadBank(BinaryData data)
        {
            ReadBank(data, false, -1, -1);
        }

        private void ReadBank(BinaryData data, bool isVanilla, int endAddress, sbyte bankID)
        {
            // Clear current list
            Behaviors.Clear();

            if (isVanilla)
            {
                while (data.Position <= endAddress - 0x10)
                {
                    var conf = new BehaviorConfig();
                    Config.BehaviorConfigs.Add(conf);
                    readBehavior(conf);
                }
            }
            else
            {
                foreach (var config in Config.BehaviorConfigs.OrderBy(n => n.BankAddress))
                    readBehavior(config);
            }

            void readBehavior(BehaviorConfig config)
            {
                int bankOffset;
                Behavior behav = new Behavior(config);

                if (isVanilla)
                {
                    bankOffset = (int)data.Position;
                    config.BankAddress = (bankID << 24) | bankOffset;
                    behav.Config.IsVanilla = true;
                }
                else
                {
                    bankOffset = config.BankAddress & 0xffffff;
                    if (!behav.Config.IsVanilla && !config.ID.HasID) config.ID.Generate();
                }

                var lastBehav = Behaviors.LastOrDefault();

                if (behav.Read(data, bankOffset, isVanilla))
                {
                    if (isVanilla && lastBehav is object && lastBehav.Config.IsVanilla && lastBehav.Config.FixedLength != -1)
                        lastBehav.Config.FixedLength = bankOffset - (lastBehav.Config.BankAddress & 0xffffff);

                    Behaviors.Add(behav);
                }
            }
        }

        public SegmentedBank WriteToSeg(byte bankID, int offset, RomManager rommgr)
        {
            var segStream = new MemoryStream();
            var seg = new SegmentedBank(bankID, segStream);
            int lastPos = WriteToSeg(seg, offset, rommgr);
            seg.Length = General.HexRoundUp1(lastPos);
            return seg;
        }

        public int WriteToSeg(SegmentedBank seg, int offset, RomManager rommgr)
        {
            var addressUpdates = new Dictionary<int, int>();
            var segStartAddress = seg.BankAddress | offset;
            var data = new BinaryStreamData(seg.Data);
            data.Position = offset;

            if (Behaviors.Any())
            {
                // Save Behaviors to ROM
                foreach (var behav in Behaviors)
                {
                    var address = (int)data.Position;
                    var newBankAddress = (int)data.Position - offset + segStartAddress;
                    if (newBankAddress != behav.Config.BankAddress)
                    {
                        if (behav.Config.BankAddress != -1)
                            addressUpdates.Add(behav.Config.BankAddress, newBankAddress);
                        behav.Config.BankAddress = newBankAddress;
                    }
                    behav.Write(data, (int)data.Position);
                }
            }

            // Delete unused configs / Add new configs
            Config.BehaviorConfigs.Clear();
            Config.BehaviorConfigs.AddRange(Behaviors.Select(n => n.Config));

            // Update addresses
            UpdateBehaviorAddresses(rommgr, addressUpdates);

            return (int)data.Position;
        }

        private void UpdateBehaviorAddresses(RomManager rommgr, Dictionary<int, int> addressUpdates)
        {
            if (Behaviors.Any() && rommgr is object)
            {
                foreach (var lvl in rommgr.Levels)
                {
                    foreach (var area in lvl.Areas)
                    {
                        foreach (var obj in area.Objects)
                        {
                            var behavAddr = Levels.Script.Commands.clNormal3DObject.GetSegBehaviorAddr(obj);
                            foreach (var kvp in addressUpdates)
                            {
                                if (behavAddr == kvp.Key)
                                    Levels.Script.Commands.clNormal3DObject.SetSegBehaviorAddr(obj, (uint)kvp.Value);
                            }
                        }
                    }
                }
            }
        }

        public void WriteBehaviorAddresss(RomManager rommgr)
        {
            var data = rommgr.GetBinaryRom(FileAccess.ReadWrite);
            WriteBehaviorAddresss(data);
            data.Close();
        }

        public void WriteBehaviorAddresss(BinaryData data)
        {
            if (Behaviors.Any())
            {
                foreach (var behav in Behaviors)
                {
                    foreach (var dest in behav.BehaviorAddressDestinations)
                    {
                        data.Position = dest;
                        data.Write(behav.Config.BankAddress);
                    }
                }
            }
        }

        public Behavior GetBehaviorByBankAddress(int bankAddress)
        {
            return Behaviors.FirstOrDefault(n => n.Config.BankAddress == bankAddress);
        }

        public void CalculateBehaviorBankAddresses(int bankStartAddress, RomManager rommgr)
        {
            var length = 0;
            var addressUpdates = new Dictionary<int, int>();

            foreach (var behav in Behaviors)
            {
                if (behav.Config.IsVanilla)
                    length += behav.Config.FixedLength;
                else
                {
                    var newBankAddress = bankStartAddress + length;
                    addressUpdates.AddIfNotContainsKey(behav.Config.BankAddress, newBankAddress);
                    behav.Config.BankAddress = newBankAddress;
                    length += (int)behav.Script.Length;
                }
            }

            // Update addresses
            UpdateBehaviorAddresses(rommgr, addressUpdates);
        }
    }
}
