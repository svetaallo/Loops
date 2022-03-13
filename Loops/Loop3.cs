using System;
using System.Collections.Generic;
using System.Text;

namespace Loops
{
    class Loop3
    {
        public static int DoTask(int n)
        {
            string line = "";
            for(int i = 1; line.Length <= n; i++)
            {
                line += i;
            }
            return Int32.Parse(line[n-1]+"");
        }
    }
}
