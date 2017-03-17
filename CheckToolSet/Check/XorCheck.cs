using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckToolSet.Check
{
    public class XorCheck
    {
        public static UInt16 GetCheck(byte[] data)
        {
            UInt16 check = 0;
            foreach (byte d in data)
            {
                check ^= d;
            }

            return check;
        }
    }
}
