using System;
using System.Collections.Generic;
using System.Text;

namespace Loops
{
    class Loop2
    {
        public static int DoTask(int n)
        {
            var sum = 0;
            for (int i = 1; i <= 9; i++)
                for (int j = 0; j <= 9; j++)
                    for (int k = 0; k <= 9; k++)
                        if (i + j + k == n)
                            sum ++;
            return sum;
        }
    }
}
