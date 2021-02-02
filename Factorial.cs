using System;
using System.Collections.Generic;
using System.Text;

namespace hackerrank2
{
    class Factorial
    {

        public static long ReturnFact(long n)
        {
            if (n == 0)
            {
                return 1;
            }

            long x = n * ReturnFact(n - 1);

            return x;
        }
    }
}
