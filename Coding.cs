using System;
using System.Collections.Generic;
using System.Text;

namespace CodingText
{
    public static class Coding
    {

        public static byte[] BinEncrypt(string word, out int SaveSize)
        {
            SaveSize = word.Length;
            byte[] array = System.Text.Encoding.Default.GetBytes(word);
            array = GetBitArray(array);
            return array;
        }
        public static string Translate(byte[]array , int size)
        {
            byte[] oldarray = GetOldArray(array, size);
            string txt= System.Text.Encoding.Default.GetString(oldarray);
            return txt;
        } 
        public static byte[] GetOldArray(byte[] array, int size)
        {
            byte[] oldarray = new byte[size];
            for (int i = 0, k = 0, c = 4; i < size; i++, c += 4)
            {
                for (int pow = 3; k < c; k++)
                {
                    oldarray[i] += (byte)(array[k] * Math.Pow(2, pow--));
                }


            }
            return oldarray;
        }
        public static byte[] GetBitArray(byte[] array)
        {
            List<byte> listbyte = new List<byte>();
            byte memory;
            for (int i = 0; i < array.Length; i++)
            {
                for (; array[i] != 0;)
                {
                    listbyte.Add((byte)(array[i] % 2));
                    memory = (byte)(array[i] / 2);
                    array[i] = memory;
                }
            }
            listbyte.Reverse();
            byte[] returByte = listbyte.ToArray();
            return returByte;
        }
    }
}
