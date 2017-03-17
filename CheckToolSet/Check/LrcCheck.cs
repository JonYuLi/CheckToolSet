using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckToolSet.Check
{
    public class LrcCheck
    {
        public static byte GetCheck(byte[] data)
        {
            byte check = 0;
            foreach (byte d in data)
            {
                check += d;
            }

            check = (byte)(~check) ;

            check = (byte)(check + 1);

            return check;
        }
    }
}
