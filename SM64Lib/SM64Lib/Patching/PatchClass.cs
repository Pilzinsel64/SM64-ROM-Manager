using System;
using System.Diagnostics;
using global::System.IO;
using global::System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64Lib.Data;

namespace SM64Lib.Patching
{
    public class PatchClass
    {
        private BinaryData data = null;

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public void ApplyPPF(string Romfile, string PPFFile)
        {
            RunProcess(General.MyFilePaths["ApplyPPF3.exe"], string.Format("a \"{0}\" \"{1}\"", Romfile, PPFFile));
        }

        private int RunProcess(string Filename, string Args = "")
        {
            var p = new Process();
            {
                var withBlock = p.StartInfo;
                withBlock.CreateNoWindow = true;
                withBlock.FileName = Filename;
                withBlock.Arguments = Args;
                withBlock.UseShellExecute = false;
            }

            p.Start();
            while (!p.HasExited)
                Application.DoEvents();
            return p.ExitCode;
        }
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public void UpdateChecksum(string Romfile)
        {
            RunProcess(General.MyFilePaths["rn64crc.exe"], $"\"{Romfile}\" -u");
        }

        public void RestoreChecksum()
        {
            data.Position = 0x66C;
            data.Write(350748678U);
            data.Position = 0x678;
            data.Write(369623043U);
        }
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public void Open(string Romfile, bool OnlyRead)
        {
            Open(new BinaryFile(Romfile, FileMode.Open, OnlyRead ? FileAccess.Read : FileAccess.ReadWrite));
        }

        public void Open(BinaryData data)
        {
            this.data = data;
        }

        public void Open(Stream s)
        {
            Open(new BinaryStreamData(s));
        }

        public void Close()
        {
            data.Close();
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public void ActSelector_ApplyPatch()
        {
            // Write Original Data
            data.Position = 0x1202EC0;
            foreach (byte b in new[] { 0, 0, 0, 0, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 17 }) // {0, 0, 0, 0, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 17}
                data.Write(b);

            // Update Pointers
            data.Position = 0x6F38;
            data.Write(0x2B010001U);
            data.Position = 0x6F50;
            data.Write(0x8100BC0U);
            data.Write(0);

            // Write Function
            data.Position = 0x1202F00;
            foreach (byte b in new[] { 60, 1, 128, 51, 132, 33, 221, 248, 60, 8, 128, 64, 53, 8, 46, 192, 1, 1, 64, 33, 145, 8, 0, 0, 36, 1, 0, 1, 16, 40, 0, 3, 36, 0, 0, 0, 8, 9, 47, 228, 0, 0, 16, 37, 8, 9, 47, 214, 36, 0, 0, 0, 1, 1, 1, 1 })
                data.Write(b);
        }

        public bool get_ActSelector_Enabled(int LevelID)
        {
            data.Position = 0x1202EC0 + LevelID;
            return Convert.ToBoolean(data.ReadByte());
        }

        public void set_ActSelector_Enabled(int LevelID, bool value)
        {
            data.Position = 0x1202EC0 + LevelID;
            data.Write(value ? Conversions.ToByte(0x1) : Conversions.ToByte(0x0));
        }
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public void HardcodedCamera_ApplyPatch()
        {
            data.Position = 0x41AD8;
            data.Write(202378196U);
            data.Write(2409889856U);
            data.Position = 0x1202F50;
            data.Write(666763240U);
            data.Write(2948530196U);
            data.Write(1006731315U);
            data.Write(2216812024U);
            data.Write(1007190080U);
            data.Write(889728592U);
            data.Write(16859169U);
            data.Write(2433220608U);
            data.Write(604045313U);
            data.Write(271056899U);
            data.Write(603979776U);
            data.Write(65011720U);
            data.Write(666697752U);
            data.Write(201997228U);
            data.Write(0U);
            data.Write(2411659284U);
            data.Write(65011720U);
            data.Write(666697752U);
            data.Position = 0x1202E50;
            for (int index = 0; index <= 43; index++)
                data.Write(Conversions.ToByte(0x1));
        }

        public void HardcodedCamera_DisableAll()
        {
            for (int i = 0; i <= 30; i++)
            {
                data.Position = 0x1202E50 + General.GetLevelIDFromIndex(Conversions.ToByte(i));
                data.Write(Conversions.ToByte(0x0));
            }
        }

        public void HardcodedCamera_EnableAll()
        {
            for (int i = 0; i <= 30; i++)
            {
                data.Position = 0x1202E50 + General.GetLevelIDFromIndex(Conversions.ToByte(i));
                data.Write(Conversions.ToByte(0x1));
            }
        }

        public bool get_HardcodedCamera_Enabled(int Levelindex)
        {
            data.Position = 0x1202E50 + General.GetLevelIDFromIndex(Conversions.ToByte(Levelindex));
            if (data.ReadByte() == 0x1)
                return true;
            else
                return false;
        }

        public void set_HardcodedCamera_Enabled(int Levelindex, bool value)
        {
            if (!data.CanWrite)
                return;
            data.Position = 0x1202E50 + General.GetLevelIDFromIndex(Conversions.ToByte(Levelindex));
            if (value)
            {
                data.Write(Conversions.ToByte(0x1));
            }
            else
            {
                data.Write(Conversions.ToByte(0x0));
            }
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public void SetPauseMenuWarp(short levelID, short areaID, short warpID)
        {
            // Level ID
            data.Position = 0x666A;
            data.Write(levelID);

            // Area ID
            data.Position = 0x666E;
            data.Write(areaID);

            // Warp ID
            data.Position = 0x6672;
            data.Write(warpID);
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}