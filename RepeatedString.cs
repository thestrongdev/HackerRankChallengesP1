using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace hackerrank2
{
    class RepeatedString
    {

        static public long RepeatString(string s, long n) //return number of "a"s in this repeated string with n characters
        {
            if (n == 0)
            {
                return 0;
            }

            //NEEDED FOR ALL WAYS
            long stringLength = s.Length;
            long totalNumberOfRepeats = n / stringLength;
            long remainder = n % s.Length; //how can this return a value less than zero?
            long theInitialACount = 0;
            long theTotalACount = 0;
            long additionalA = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if(s[i] == 'a' || s[i] == 'A')
                {
                    theInitialACount += 1;
                }
            }

            for (int i = 0; i < remainder; i++)
            {
                if (s[i] == 'a' || s[i] == 'A')
                {
                    additionalA += 1;
                }
            }
            
            theTotalACount = theInitialACount * totalNumberOfRepeats;
            theTotalACount += additionalA;

            return theTotalACount;

            //FASTER WAY but doesn't allow for long values in String concat. max capacity
            //long totalNumberOfRepeats = n / s.Length;
            //long remainder = n % s.Length;
            //long theACount = 0;
            //string final = String.Concat(Enumerable.Repeat(s, (int)totalNumberOfRepeats));
            //final = final + s.Substring(0, (int)remainder);
            //theACount = final.Count(c => (c == 'a'));
            //return theACount;

            //----------------------------------------------------------------

            //FASTER WAY but doesn't allow for long values in SB max capacity
            //StringBuilder newString = new StringBuilder((int)n); // can't use for LONG items
            //newString.Insert(0, s, (int)totalNumberOfRepeats);
            //string final = newString.ToString();
            //final = final + s.Substring(0, (int)remainder);
            //theACount = final.Count(c => (c == 'a'));

            //----------------------------------------------------------------

            //LESS OPTIMIZED CODE HERE:
            //needed for first attempt - less optimized way
            //char[] toRepeatedlyLoopThrough = s.ToCharArray();
            //int secondCount = 0;

            //for (int i = 0; i < n; i++)
            //{
            //    if( toRepeatedlyLoopThrough[secondCount].Equals('a') || toRepeatedlyLoopThrough[secondCount].Equals('A'))
            //    {
            //        theACount += 1;
            //    }

            //    if(secondCount == s.Length-1)
            //    {
            //        secondCount = 0;
            //    }
            //    else
            //    {
            //        secondCount += 1;
            //    }
            //}


        }

    }
}
