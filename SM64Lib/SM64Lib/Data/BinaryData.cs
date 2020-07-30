using global::System.IO;
using SM64Lib.Data.System;
using System;

namespace SM64Lib.Data
{
    public abstract class BinaryData : IDisposable
    {
        public delegate void AnyBinaryDataEventHandler(BinaryData data);

        public static event AnyBinaryDataEventHandler AnyBinaryDataOpened;
        public static event AnyBinaryDataEventHandler AnyBinaryDataClosing;
        public static event AnyBinaryDataEventHandler AnyBinaryDataClosed;
        public static event AnyBinaryDataDisposedEventHandler AnyBinaryDataDisposed;

        public delegate void AnyBinaryDataDisposedEventHandler();

        private Stream _BaseStream = null;
        private BinaryWriter _writer = null;
        private BinaryReader _reader = null;

        public RomManager RomManager { get; private set; }

        protected abstract Stream GetBaseStream();

        protected BinaryWriter Writer
        {
            get
            {
                if (_writer is null)
                {
                    _writer = new BinaryWriter(BaseStream);
                }

                return _writer;
            }
        }

        protected BinaryReader Reader
        {
            get
            {
                if (_reader is null)
                {
                    _reader = new BinaryReader(BaseStream);
                }

                return _reader;
            }
        }

        public long Position
        {
            get
            {
                return BaseStream.Position;
            }

            set
            {
                BaseStream.Position = value;
            }
        }

        public long Length
        {
            get
            {
                return BaseStream.Length;
            }
        }

        public Stream BaseStream
        {
            get
            {
                if (_BaseStream is null)
                {
                    _BaseStream = GetBaseStream();
                    RaiseAnyBinaryDataOpened(this);
                }

                return _BaseStream;
            }
        }

        ~BinaryData()
        {
            AnyBinaryDataDisposed?.Invoke();
        }

        public void RoundUpPosition()
        {
            Position = General.HexRoundUp1(Position);
        }

        public void RoundUpPosition(int add)
        {
            Position = General.HexRoundUp1(Position + add);
        }

        protected void SetRomManager(RomManager rommgr)
        {
            RomManager = rommgr;
        }

        public void Write(sbyte value)
        {
            Writer.Write(value);
        }

        public void Write(byte value)
        {
            Writer.Write(value);
        }

        public void WriteByte(byte value)
        {
            Write(value);
        }

        public void Write(short value)
        {
            Writer.Write(SwapInts.SwapInt16(value));
        }

        public void Write(ushort value)
        {
            Writer.Write(SwapInts.SwapUInt16(value));
        }

        public void Write(int value)
        {
            Writer.Write(SwapInts.SwapInt32(value));
        }

        public void Write(uint value)
        {
            Writer.Write(SwapInts.SwapUInt32(value));
        }

        public void Write(long value)
        {
            Writer.Write(SwapInts.SwapInt64(value));
        }

        public void Write(ulong value)
        {
            Writer.Write(SwapInts.SwapUInt64(value));
        }

        public void Write(float value, bool isHalf = false)
        {
            if (isHalf)
                Writer.Write(SwapInts.SwapHalf(value));
            else
                Writer.Write(SwapInts.SwapFloat32(value));
        }

        public void Write(string value)
        {
            Writer.Write(value);
        }

        public void Write(byte[] buffer)
        {
            Write(buffer, 0, buffer.Length);
        }

        public void Write(byte[] buffer, int index, int count)
        {
            Writer.Write(buffer, index, count);
        }

        public byte ReadByte()
        {
            return Reader.ReadByte();
        }

        public sbyte ReadSByte()
        {
            return Reader.ReadSByte();
        }

        public short ReadInt16()
        {
            return SwapInts.SwapInt16(Reader.ReadInt16());
        }

        public ushort ReadUInt16()
        {
            return SwapInts.SwapUInt16(Reader.ReadUInt16());
        }

        public int ReadInt32()
        {
            return SwapInts.SwapInt32(Reader.ReadInt32());
        }

        public uint ReadUInt32()
        {
            return SwapInts.SwapUInt32(Reader.ReadUInt32());
        }

        public long ReadInt64()
        {
            return SwapInts.SwapInt64(Reader.ReadInt64());
        }

        public ulong ReadUInt64()
        {
            return SwapInts.SwapUInt64(Reader.ReadUInt64());
        }

        public float ReadSingle()
        {
            return SwapInts.SwapFloat32(Reader.ReadSingle());
        }

        public string ReadString()
        {
            return Reader.ReadString();
        }

        public void Read(byte[] buffer)
        {
            Read(buffer, 0, buffer.Length);
        }

        public void Read(byte[] buffer, int index, int count)
        {
            Reader.Read(buffer, index, count);
        }

        public byte[] Read(int count)
        {
            var buf = new byte[count];
            Read(buf, 0, count);
            return buf;
        }

        public void Close()
        {
            AnyBinaryDataClosing?.Invoke(this);
            BaseStream.Close();
            AnyBinaryDataClosed?.Invoke(this);
        }

        public bool CanRead
        {
            get
            {
                return BaseStream.CanRead;
            }
        }

        public bool CanWrite
        {
            get
            {
                return BaseStream.CanWrite;
            }
        }

        public void SetLength(long length)
        {
            BaseStream.SetLength(length);
        }

        internal static void RaiseAnyBinaryDataOpened(BinaryData data)
        {
            AnyBinaryDataOpened?.Invoke(data);
        }

        public void Dispose()
        {
            //if(this is BinaryFile)
            //{
            //    _reader?.Close();
            //    _writer?.Close();
            //    _BaseStream.Close();
            //}
        }
    }
}