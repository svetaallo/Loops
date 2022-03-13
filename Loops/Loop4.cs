using System;
using System.Collections.Generic;
using System.Text;

namespace Loops
{
    class Loop4
    {
        public static double[] array = new double[] { 0, 1, 1, 1, 0, 0, 2, 3, 1, 4, 4, 4, 4, 4, 4, 1, 1, 1, 1 };

        public static double[] FindLongestSubarray(double[] array)
        {
            var previousNumber = array[0];
            (int lastIndex, int length) subarray = (0, 0);
            (int lastIndex, int length) biggestSubarray = (0, 0);

            for (int i = 0; i < array.Length; i++)
            {
                if(array[i]==previousNumber)
                {
                    subarray.lastIndex = i;
                    subarray.length++;
                    if(subarray.length > biggestSubarray.length)
                    {
                        biggestSubarray = subarray;
                    }
                }
                else
                {
                    previousNumber = array[i];
                    subarray = (i, 1);
                }
            }
            var largestSubarray = new double[biggestSubarray.length];
            Array.Copy(array, biggestSubarray.lastIndex - biggestSubarray.length + 1, largestSubarray, 0, biggestSubarray.length);
            return largestSubarray;
        }
    }
}
