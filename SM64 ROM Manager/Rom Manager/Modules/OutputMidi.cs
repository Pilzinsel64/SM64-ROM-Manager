// ========================================================================
// This conversion was produced by the Free Edition of
// Instant VB courtesy of Tangible Software Solutions.
// Order the Premium Edition at https://www.tangiblesoftwaresolutions.com
// ========================================================================

using System;
using global::System.IO;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager
{
    public class OutputMIDI
    {
        public static SettingsData Settings { get; private set; } = new SettingsData();
        public static HeaderClass HeaderData { get; private set; } = new HeaderClass();
        public static TrackClass TrackData { get; private set; } = new TrackClass();
        public static LayerClass LayerData { get; private set; } = new LayerClass();
        public static NoteClass NoteData { get; private set; } = new NoteClass();

        public static byte FirstByte(int value)
        {
            return BitConverter.GetBytes(value)[0];
        }

        public static void Advance(BinaryReader br, int value)
        {
            br.BaseStream.Position += Conversions.ToLong(value);
        }

        public static void ReadHeader(BinaryReader br)
        {
            while (br.BaseStream.Position < br.BaseStream.Length)
            {
                byte num = br.ReadByte();
                if (Conversions.ToInteger(num) >= 144 && Conversions.ToInteger(num) <= 159)
                {
                    Advance(br, 2);
                }

                if (Conversions.ToInteger(num) == 196)
                {
                    break;
                }

                if (Conversions.ToInteger(num) == 200)
                {
                    Advance(br, 1);
                }

                if (Conversions.ToInteger(num) == 211)
                {
                    Advance(br, 1);
                    HeaderData.Valid = true;
                }

                if (Conversions.ToInteger(num) == 213)
                {
                    Advance(br, 1);
                }

                if (Conversions.ToInteger(num) == 214)
                {
                    Advance(br, 2);
                }

                if (Conversions.ToInteger(num) == 215)
                {
                    Advance(br, 2);
                }

                if (Conversions.ToInteger(num) == 217)
                {
                    Advance(br, 1);
                }

                if (Conversions.ToInteger(num) == 219)
                {
                    HeaderData.Volume = br.ReadByte();
                }

                if (Conversions.ToInteger(num) == 221)
                {
                    HeaderData.Tempo = br.ReadByte();
                }

                if (Conversions.ToInteger(num) == 249)
                {
                    Advance(br, 2);
                }

                if (Conversions.ToInteger(num) == 250)
                {
                    Advance(br, 2);
                }

                if (Conversions.ToInteger(num) == 251)
                {
                    HeaderData.LoopOffset = Conversions.ToInteger(Reverse.Int16(br.ReadInt16())) & Conversions.ToInteger(ushort.MaxValue);
                }

                if (Conversions.ToInteger(num) == 253)
                {
                    HeaderData.MaxTimestamp += Conversions.ToInteger(ReadParameter(br));
                }

                if (Conversions.ToInteger(num) == Conversions.ToInteger(byte.MaxValue))
                {
                    break;
                }
            }
        }

        public static void ReadNote(BinaryReader br, byte by)
        {
            int num = 0;
            if (Conversions.ToInteger(by) >= 0 && Conversions.ToInteger(by) <= 63)
            {
                num = Conversions.ToInteger(by);
                NoteData.Timestamp = Conversions.ToInteger(ReadParameter(br));
                NoteData.Velocity = br.ReadByte();
                NoteData.Duration = br.ReadByte();
            }

            if (Conversions.ToInteger(by) >= 64 && Conversions.ToInteger(by) <= Conversions.ToInteger(sbyte.MaxValue))
            {
                num = Conversions.ToInteger(by) - 64;
                NoteData.Timestamp = Conversions.ToInteger(ReadParameter(br));
                NoteData.Velocity = br.ReadByte();
            }

            if (Conversions.ToInteger(by) >= 128 && Conversions.ToInteger(by) <= 191)
            {
                num = Conversions.ToInteger(by) - 128;
                NoteData.Velocity = br.ReadByte();
                NoteData.Duration = br.ReadByte();
            }

            NoteData.Key = FirstByte(num);
            LayerData.TotalTimestamp += NoteData.Timestamp;
        }

        public static short ReadParameter(BinaryReader br)
        {
            int num = Conversions.ToInteger(Math.Truncate((decimal)br.ReadByte()));
            if ((num & 128) == 128)
            {
                num = (num << 8) + Conversions.ToInteger(Math.Truncate((decimal)br.ReadByte()));
                if ((num & 32640) == 0)
                {
                    num = 192;
                    br.BaseStream.Position -= 1;
                }
            }

            return BitConverter.ToInt16(BitConverter.GetBytes(num & Conversions.ToInteger(short.MaxValue)), 0);
        }

        public static void ConvertHeader(BinaryReader br, BinaryWriter bw, byte track, byte layer)
        {
            if (Conversions.ToInteger(Settings.LimitChunks) == 2)
            {
                br.BaseStream.Position = Conversions.ToLong(HeaderData.LoopOffset);
            }

            while (br.BaseStream.Position < br.BaseStream.Length)
            {
                byte num = br.ReadByte();
                if (Conversions.ToInteger(num) >= 144 && Conversions.ToInteger(num) <= 159)
                {
                    if (Conversions.ToInteger(num) == (144 | Conversions.ToInteger(track)))
                    {
                        HeaderData.ReturnOffset = br.BaseStream.Position + 2L;
                        br.BaseStream.Position = Conversions.ToLong(Conversions.ToInteger(Reverse.Int16(br.ReadInt16())) & Conversions.ToInteger(ushort.MaxValue));
                        ConvertTrack(br, bw, track, layer);
                        br.BaseStream.Position = HeaderData.ReturnOffset;
                    }
                    else
                    {
                        Advance(br, 2);
                    }
                }

                if (Conversions.ToInteger(num) == 196)
                {
                    break;
                }

                if (Conversions.ToInteger(num) == 200)
                {
                    Advance(br, 1);
                }

                if (Conversions.ToInteger(num) == 211)
                {
                    Advance(br, 1);
                }

                if (Conversions.ToInteger(num) == 213)
                {
                    Advance(br, 1);
                }

                if (Conversions.ToInteger(num) == 214)
                {
                    Advance(br, 2);
                }

                if (Conversions.ToInteger(num) == 215)
                {
                    Advance(br, 2);
                }

                if (Conversions.ToInteger(num) == 217)
                {
                    Advance(br, 1);
                }

                if (Conversions.ToInteger(num) == 219)
                {
                    Advance(br, 1);
                }

                if (Conversions.ToInteger(num) == 221)
                {
                    Advance(br, 1);
                }

                if (Conversions.ToInteger(num) == 249)
                {
                    Advance(br, 2);
                }

                if (Conversions.ToInteger(num) == 250)
                {
                    Advance(br, 2);
                }

                if (Conversions.ToInteger(num) == 251)
                {
                    Advance(br, 2);
                }

                if (Conversions.ToInteger(num) == 253)
                {
                    HeaderData.TotalTimestamp += Conversions.ToInteger(ReadParameter(br));
                    if (HeaderData.TotalTimestamp > LayerData.TotalTimestamp)
                    {
                        NoteData.RestTimestamp = HeaderData.TotalTimestamp - LayerData.TotalTimestamp;
                    }
                }

                if (Conversions.ToInteger(num) == Conversions.ToInteger(byte.MaxValue) || Conversions.ToInteger(Settings.LimitChunks) == 1 && br.BaseStream.Position >= Conversions.ToLong(HeaderData.LoopOffset))
                {
                    break;
                }
            }
        }

        public static void ConvertTrack(BinaryReader br, BinaryWriter bw, byte track, byte layer)
        {
            while (br.BaseStream.Position < br.BaseStream.Length)
            {
                byte num = br.ReadByte();
                if (Conversions.ToInteger(num) >= 144 && Conversions.ToInteger(num) <= 159)
                {
                    if (Conversions.ToInteger(num) == (144 | Conversions.ToInteger(layer)))
                    {
                        TrackData.ReturnOffset = br.BaseStream.Position + 2L;
                        br.BaseStream.Position = Conversions.ToLong(Conversions.ToInteger(Reverse.Int16(br.ReadInt16())) & Conversions.ToInteger(ushort.MaxValue));
                        ConvertLayer(br, bw, track, layer);
                        br.BaseStream.Position = TrackData.ReturnOffset;
                        if (!HeaderData.ActiveLayers[Conversions.ToInteger(track), Conversions.ToInteger(num) & 15])
                        {
                            HeaderData.TotalLayers += 1;
                        }

                        HeaderData.ActiveLayers[Conversions.ToInteger(track), Conversions.ToInteger(num) & 15] = true;
                    }
                    else
                    {
                        Advance(br, 2);
                    }
                }

                if (Conversions.ToInteger(num) == 193)
                {
                    TrackData.Program = br.ReadByte();
                }

                if (Conversions.ToInteger(num) == 194)
                {
                    Advance(br, 2);
                }

                if (Conversions.ToInteger(num) == 198)
                {
                    Advance(br, 1);
                }

                if (Conversions.ToInteger(num) == 200)
                {
                    Advance(br, 1);
                }

                if (Conversions.ToInteger(num) == 202)
                {
                    Advance(br, 1);
                }

                if (Conversions.ToInteger(num) == 204)
                {
                    Advance(br, 2);
                }

                if (Conversions.ToInteger(num) == 208)
                {
                    Advance(br, 1);
                }

                if (Conversions.ToInteger(num) == 211)
                {
                    Advance(br, 1);
                }

                if (Conversions.ToInteger(num) == 212)
                {
                    Advance(br, 1);
                }

                if (Conversions.ToInteger(num) == 216)
                {
                    Advance(br, 1);
                }

                if (Conversions.ToInteger(num) == 220)
                {
                    Advance(br, 1);
                }

                if (Conversions.ToInteger(num) == 221)
                {
                    TrackData.Pan = br.ReadByte();
                }

                if (Conversions.ToInteger(num) == 223)
                {
                    Advance(br, 1);
                }

                if (Conversions.ToInteger(num) == 224)
                {
                    Advance(br, 1);
                }

                if (Conversions.ToInteger(num) == 229)
                {
                    Advance(br, 1);
                }

                if (Conversions.ToInteger(num) == 233)
                {
                    Advance(br, 1);
                }

                if (Conversions.ToInteger(num) == 250)
                {
                    Advance(br, 2);
                }

                if (Conversions.ToInteger(num) == 251)
                {
                    Advance(br, 2);
                }

                if (Conversions.ToInteger(num) == 253)
                {
                    TrackData.TotalTimestamp += Conversions.ToInteger(ReadParameter(br));
                    if (TrackData.TotalTimestamp > LayerData.TotalTimestamp)
                    {
                        NoteData.RestTimestamp = TrackData.TotalTimestamp - LayerData.TotalTimestamp;
                    }
                }

                if (Conversions.ToInteger(num) == 254)
                {
                    Advance(br, 1);
                }

                if (Conversions.ToInteger(num) == Conversions.ToInteger(byte.MaxValue))
                {
                    break;
                }
            }
        }

        public static void ConvertLayer(BinaryReader br, BinaryWriter bw, byte track, byte layer)
        {
            NoteData.FirstNote = true;
            while (br.BaseStream.Position < br.BaseStream.Length)
            {
                byte by = br.ReadByte();
                if (Conversions.ToInteger(by) >= 0 && Conversions.ToInteger(by) <= 191)
                {
                    ReadNote(br, by);
                    WriteNote(bw, track);
                    NoteData.RestTimestamp = 0;
                    NoteData.FirstNote = false;
                }

                if (Conversions.ToInteger(by) == 192)
                {
                    short num = ReadParameter(br);
                    NoteData.RestTimestamp += Conversions.ToInteger(num);
                    LayerData.TotalTimestamp += Conversions.ToInteger(num);
                }

                if (Conversions.ToInteger(by) == 194)
                {
                    NoteData.Transposition = br.ReadByte();
                }

                if (Conversions.ToInteger(by) == 252)
                {
                    LayerData.ReturnOffset = br.BaseStream.Position + 2L;
                    br.BaseStream.Position = Conversions.ToLong(Conversions.ToInteger(Reverse.Int16(br.ReadInt16())) & Conversions.ToInteger(ushort.MaxValue));
                    NoteData.InJump = true;
                }

                if (Conversions.ToInteger(by) == Conversions.ToInteger(byte.MaxValue))
                {
                    if (!NoteData.InJump)
                    {
                        break;
                    }

                    br.BaseStream.Position = LayerData.ReturnOffset;
                    NoteData.InJump = false;
                }

                if (LayerData.TotalTimestamp >= HeaderData.MaxTimestamp && Settings.Restrict)
                {
                    break;
                }
            }
        }

        public static void WriteMeta(BinaryWriter bw, int delta, int value)
        {
            WriteDelta(bw, delta);
            bw.Write(FirstByte(Conversions.ToInteger(byte.MaxValue)));
            bw.Write(FirstByte(value));
        }

        public static void WriteDelta(BinaryWriter bw, int delta)
        {
            int num1 = 0;
            byte index = 0;
            while (Conversions.ToInteger(index) < 4)
            {
                byte num2 = FirstByte(delta << Conversions.ToInteger(index) >> 8 * Conversions.ToInteger(index));
                if (Conversions.ToInteger(index) == 0)
                {
                    num1 = num1 | (Conversions.ToInteger(num2) & Conversions.ToInteger(sbyte.MaxValue)) << 8 * Conversions.ToInteger(index);
                }
                else if (Conversions.ToInteger(num2) != 0)
                {
                    num1 = num1 | ((Conversions.ToInteger(num2) | 128) & Conversions.ToInteger(byte.MaxValue)) << 8 * Conversions.ToInteger(index);
                }

                index += 1;
            }

            var bytes = BitConverter.GetBytes(num1);
            if (Conversions.ToInteger(bytes[3]) != 0)
            {
                bw.Write(Reverse.Int32(BitConverter.ToInt32(bytes, 0)));
            }
            else if (Conversions.ToInteger(bytes[2]) != 0)
            {
                bw.Write(bytes[2]);
                bw.Write(bytes[1]);
                bw.Write(bytes[0]);
            }
            else if (Conversions.ToInteger(bytes[1]) != 0)
            {
                bw.Write(Reverse.Int16(BitConverter.ToInt16(bytes, 0)));
            }
            else
            {
                bw.Write(bytes[0]);
            }
        }

        public static void WriteNote(BinaryWriter bw, byte track)
        {
            WriteDelta(bw, NoteData.RestTimestamp);
            if (NoteData.FirstNote)
            {
                bw.Write(FirstByte(144 | Conversions.ToInteger(track)));
            }

            bw.Write(FirstByte(Conversions.ToInteger(NoteData.Key) + Conversions.ToInteger(NoteData.Transposition) + 21));
            bw.Write(NoteData.Velocity);
            WriteDelta(bw, NoteData.Timestamp);
            bw.Write(FirstByte(Conversions.ToInteger(NoteData.Key) + Conversions.ToInteger(NoteData.Transposition) + 21));
            bw.Write(FirstByte(0));
        }

        public static void StartMIDIHeader(BinaryWriter bw)
        {
            bw.Write(Reverse.String32("MThd"));
            bw.Write(Reverse.Int32(6));
            bw.Write(Reverse.Int16(Conversions.ToShort(1)));
            bw.Write(Reverse.Int16(Conversions.ToShort(0)));
            bw.Write(Reverse.Int16(Conversions.ToShort(48)));
        }

        public static void FinishMIDIHeader(BinaryWriter bw)
        {
            bw.BaseStream.Position = 10L;
            HeaderData.TotalLayers += 1;
            // INSTANT VB WARNING: An assignment within expression was extracted from the following statement:
            // ORIGINAL LINE: bw.Write(OutputMIDI.Reverse.Int16(++OutputMIDI.HeaderData.TotalLayers));
            bw.Write(Reverse.Int16(HeaderData.TotalLayers));
        }

        public static void StartMIDISettings(BinaryWriter bw)
        {
            bw.Write(Reverse.String32("MTrk"));
            bw.Write(Reverse.Int32(25));
            WriteMeta(bw, 0, 88);
            bw.Write(FirstByte(4));
            bw.Write(FirstByte(4));
            bw.Write(FirstByte(2));
            bw.Write(FirstByte(24));
            bw.Write(FirstByte(8));
            WriteMeta(bw, 0, 89);
            bw.Write(FirstByte(2));
            bw.Write(FirstByte(0));
            bw.Write(FirstByte(0));
            WriteMeta(bw, 0, 81);
            bw.Write(Reverse.Int32(0));
            bw.Write(Reverse.Int32(16723712));
        }

        public static void FinishMIDISettings(BinaryWriter bw)
        {
            bw.BaseStream.Position = 39L;
            // INSTANT VB WARNING: Instant VB cannot determine whether both operands of this division are integer types - if they are then you should use the VB integer division operator:
            bw.Write(Reverse.Int32(Conversions.ToInteger((long)(60000000 / (double)(Conversions.ToInteger(HeaderData.Tempo) & Conversions.ToInteger(byte.MaxValue))) | 50331648)));
        }

        public static void StartMIDITrack(BinaryWriter bw, byte track)
        {
            bw.Write(Reverse.String32("MTrk"));
            bw.Write(Reverse.Int32(0));
            LayerData.WriteOffset = bw.BaseStream.Position;
            WriteMeta(bw, 0, 3);
            bw.Write(FirstByte(0));
            WriteControl.Program(bw, track, 0, Conversions.ToByte(0));
            WriteControl.Volume(bw, track, 0, Conversions.ToByte(127));
            WriteControl.Pan(bw, track, 0, Conversions.ToByte(0));
        }

        public static void FinishMIDITrack(BinaryWriter bw, byte track)
        {
            bw.Write(Reverse.Int32(16723712));
            long num = bw.BaseStream.Position - LayerData.WriteOffset;
            bw.BaseStream.Position = LayerData.WriteOffset - 4L;
            var bytes = BitConverter.GetBytes(num);
            bw.Write(Reverse.Int32(BitConverter.ToInt32(bytes, 0)));
            bw.BaseStream.Position = LayerData.WriteOffset + 4L;
            WriteControl.Program(bw, track, 0, TrackData.Program);
            bw.BaseStream.Position = LayerData.WriteOffset + 11L;
            WriteControl.Pan(bw, track, 0, TrackData.Pan);
            if (LayerData.TotalTimestamp > 0)
            {
                bw.BaseStream.Position = bw.BaseStream.Length;
            }
            else
            {
                bw.BaseStream.Position = bw.BaseStream.Length - 27L;
            }
        }

        public static void ConvertToMIDI(string outputFile, Stream inputStream, byte chunk, bool restrict)
        {
            Settings.LimitChunks = chunk;
            Settings.Restrict = restrict;

            // Dim fileStream1 As New FileStream(file, FileMode.Open, FileAccess.Read)
            var fileStream2 = new FileStream(outputFile, FileMode.Create, FileAccess.ReadWrite);
            var br = new BinaryReader(inputStream);
            var bw = new BinaryWriter(fileStream2);
            ReadHeader(br);
            if (!HeaderData.Valid)
            {
                throw new FormatException("Header of .m64 file is invalid!");
            }
            else
            {
                StartMIDIHeader(bw);
                StartMIDISettings(bw);
                long position = bw.BaseStream.Position;
                byte track = 0;
                while (Conversions.ToInteger(track) < 16)
                {
                    byte layer = 0;
                    while (Conversions.ToInteger(layer) < 16)
                    {
                        HeaderData.TotalTimestamp = 0;
                        br.BaseStream.Position = 0L;
                        StartMIDITrack(bw, track);
                        ConvertHeader(br, bw, track, layer);
                        FinishMIDITrack(bw, track);
                        TrackData = new TrackClass();
                        LayerData = new LayerClass();
                        NoteData = new NoteClass();
                        layer += 1;
                    }

                    track += 1;
                }

                if (position == bw.BaseStream.Position)
                {
                    br.Close();
                    bw.Flush();
                    bw.Close();
                    // fileStream1.Close()
                    fileStream2.Close();
                    HeaderData = new HeaderClass();
                    File.Delete(fileStream2.Name);
                    throw new FormatException(".m64 file is invalid!");
                }
                else
                {
                    FinishMIDIHeader(bw);
                    FinishMIDISettings(bw);
                    br.Close();
                    bw.Flush();
                    bw.Close();
                    // fileStream1.Close()
                    fileStream2.Close();
                    HeaderData = new HeaderClass();
                }
            }
        }

        public class SettingsData
        {
            public byte LimitChunks;
            public bool Restrict;
        }

        public class HeaderClass
        {
            public bool[,] ActiveLayers = new bool[16, 16];
            public long ReturnOffset;
            public int TotalTimestamp;
            public int MaxTimestamp;
            public int LoopOffset;
            public short TotalLayers;
            public byte Volume;
            public byte Tempo;
            public bool Valid;
        }

        public class TrackClass
        {
            public long ReturnOffset;
            public int TotalTimestamp;
            public byte Program;
            public byte Pan;
        }

        public class LayerClass
        {
            public long ReturnOffset;
            public long WriteOffset;
            public int TotalTimestamp;
        }

        public class NoteClass
        {
            public bool FirstNote = true;
            public int Timestamp;
            public int RestTimestamp;
            public byte Transposition;
            public byte Key;
            public byte Velocity;
            public byte Duration;
            public bool InJump;
        }

        public class Reverse
        {
            public static short Int16(short value)
            {
                var bytes = BitConverter.GetBytes(value);
                Array.Reverse(bytes);
                return BitConverter.ToInt16(bytes, 0);
            }

            public static int Int32(int value)
            {
                var bytes = BitConverter.GetBytes(value);
                Array.Reverse(bytes);
                return BitConverter.ToInt32(bytes, 0);
            }

            public static int String32(string text)
            {
                int num = 0;
                foreach (char ch in text.ToCharArray())
                    num = (num << 8) + Strings.AscW(ch);
                var bytes = BitConverter.GetBytes(num);
                Array.Reverse(bytes);
                return BitConverter.ToInt32(bytes, 0);
            }
        }

        public class WriteControl
        {
            public static void Pan(BinaryWriter bw, byte track, int delta, byte pan)
            {
                WriteDelta(bw, delta);
                bw.Write(FirstByte(176 | Conversions.ToInteger(track)));
                bw.Write(FirstByte(10));
                bw.Write(pan);
            }

            public static void Volume(BinaryWriter bw, byte track, int delta, byte volume)
            {
                WriteDelta(bw, delta);
                bw.Write(FirstByte(176 | Conversions.ToInteger(track)));
                bw.Write(FirstByte(7));
                if (Conversions.ToInteger(volume) > Conversions.ToInteger(sbyte.MaxValue))
                {
                    volume = Conversions.ToByte(127);
                }

                bw.Write(volume);
            }

            public static void Program(BinaryWriter bw, byte track, int delta, byte program)
            {
                WriteDelta(bw, delta);
                bw.Write(FirstByte(192 | Conversions.ToInteger(track)));
                bw.Write(program);
            }
        }
    }
}