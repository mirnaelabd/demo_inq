using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_inq
{
    public static  class IntExtention
    {
        public static int Reverse( this int Number)
        {
            int reversnumber = 0, reminder;
            while (Number != 0)
            {
                reminder = Number % 10;  // 12345 %10 = 4  

                reversnumber = reversnumber * 10 + reminder;
                Number = Number / 10; // 1234

            }
            return reversnumber;
        }
    }
}
