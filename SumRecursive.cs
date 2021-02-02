using System;
using System.Collections.Generic;
using System.Text;

namespace hackerrank2
{
    class SumRecursive
    {
        public static int GetSum(int x)
        {
            if (x < 0) return 0;

            return x + GetSum(x - 1);
        }
    }
}
