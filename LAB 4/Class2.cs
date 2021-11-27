using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4
{
    static class StatisticOperations
    {
        public static int Sum(this Program arr)
        {
            return arr.array.Sum();
        }

        public static int Diff(this Program arr)
        {
            return arr.array.Max() - arr.array.Min();
        }

        public static int Length(this Program arr)
        {
            return arr.array.Length;
        }

        public static int Tring(this string str, char str1)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == str1)
                    count++;
            }
            return count;
        }
    }
}
