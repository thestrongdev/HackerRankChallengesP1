using System;
using System.Collections.Generic;
using System.Text;

namespace hackerrank2
{
    class Bubbles
    {
        public static void SortBubbles(int[] array)
        {
            bool isSorted = false;
            int switcharoo;
            int lastUnsorted = array.Length - 1;
            int numSwaps = 0;

            while (!isSorted)
            {
                isSorted = true;
                for (int i = 0; i < lastUnsorted; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        numSwaps += 1;
                        switcharoo = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = switcharoo;
                        isSorted = false;
                    }
                }

                lastUnsorted--;
            }


            Console.WriteLine($"Array is sorted in {numSwaps} swaps.");
            Console.WriteLine($"First element is {array[0]}");
            Console.WriteLine($"Last element is {array[array.Length-1]}");
        }
        
        public static void SortMerged()
        {

        }
    }
}
