using System;
using System.Collections.Generic;
using System.Text;

namespace hackerrank2
{
    class StringRepRecursion
    {
        public static string RepeatString(string theString, int x)
        {
            if (x == 0) return "";
            if (x == 1) return theString;
            return theString + RepeatString(theString, x - 1);
        }
    }
}
