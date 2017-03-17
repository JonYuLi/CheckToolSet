using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckToolSet.Utility
{
    public class ConvertArray
    {
        public static byte[] CharToByte(char[] data)
        {
            byte[] retArray = new byte[data.Length];

            for (int i = 0; i < data.Length; i++)
            {
                retArray[i] = (byte)data[i];
            }

            return retArray;
        }

        public static byte[] AsciiToHex(char[] data)
        {
            int len = data.Length % 2 == 0 ? data.Length / 2 : data.Length / 2 - 1;
            byte[] retArray = new byte[data.Length / 2];
            int offset = 0;

            for (int i = 0; i < len * 2; i += 2)
            {
                retArray[offset++] = (byte)(Get_HexValue(data[i]) << 4 | Get_HexValue(data[i + 1]));
            }

            return retArray;
        }

        private static byte Get_HexValue(char value)
        {
            if (value >= 'a' && value <= 'f')
            {
                return (byte)(value - 'a' + 10);
            }
            else if (value >= 'A' && value <= 'F')
            {
                return (byte)(value - 'A' + 10);
            }
            else if (value >= '0' && value <= '9')
            {
                return (byte)(value - '0');
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
