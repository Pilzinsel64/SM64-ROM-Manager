using System;
using System.Collections;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64Lib.Data.System
{
    public class Bits
    {
        public static byte[] ByteToBitArray(byte b)
        {
            var bitarray = new BitArray(new[] { b });
            var temp = new byte[bitarray.Length];
            for (int i = 0, loopTo = bitarray.Length - 1; i <= loopTo; i++)
                temp[i] = Conversions.ToByte(bitarray[i]);
            int tindex = 0;
            var temp2 = new byte[(temp.Count())];
            for (int i = temp.Length - 1; i >= 0; i += -1)
            {
                temp2[tindex] = temp[i];
                tindex += 1;
            }

            return temp2;
        }

        public static bool[] ByteToBoolArray(byte b)
        {
            var bitarray = new BitArray(new[] { b });
            var temp = new bool[bitarray.Length];
            for (int i = 0, loopTo = bitarray.Length - 1; i <= loopTo; i++)
                temp[i] = Convert.ToBoolean(bitarray[i]);
            int tindex = 0;
            var temp2 = new bool[(temp.Count())];
            for (int i = temp.Length - 1; i >= 0; i += -1)
            {
                temp2[tindex] = temp[i];
                tindex += 1;
            }

            return temp2;
        }

        public static byte ArrayToByte(byte[] ba)
        {
            // ODER: BitArray.ToByte()

            byte endval = 0;
            int index = ba.Count() - 1;
            foreach (var bit in ba)
            {
                endval += (byte)(bit * Math.Pow(2, index));
                index -= 1;
            }

            return endval;
        }

        public static byte ArrayToByte(bool[] ba)
        {
            // ODER: BitArray.ToByte()

            byte endval = 0;
            int index = ba.Count() - 1;
            foreach (var bit in ba)
            {
                endval += (byte)((bit ? 1 : 0) * Math.Pow(2, index));
                index -= 1;
            }

            return endval;
        }

        public static byte SetInByte(byte b, int index, byte value)
        {
            var temp = ByteToBitArray(b);
            temp[index] = value;
            return ArrayToByte(temp);
        }

        public static byte SetInByte(byte b, int index, bool value)
        {
            var temp = ByteToBoolArray(b);
            temp[index] = value;
            return ArrayToByte(temp);
        }

        public static byte GetBitOfByte(byte b, int index)
        {
            return ByteToBitArray(b)[index];
        }

        public static bool GetBoolOfByte(byte b, int index)
        {
            return ByteToBoolArray(b)[index];
        }
    }
}