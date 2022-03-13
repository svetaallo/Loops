using System;
using System.Collections.Generic;
using System.Text;

namespace Loops
{
    class Loop1
    {
        public static int ReverseInt(int x)
        {
            var reversed = 0;
            var pow = 0;
            var bufX = x;
            while(x>0)
            {
                x /= 10;
                pow++;
            }
            for(int i = 0; bufX > 0; pow--)
            {
                reversed += (bufX % 10) * (int)Math.Pow(10,pow-1);
                bufX = bufX / 10;
            }
            return reversed;
        }
    }
}
