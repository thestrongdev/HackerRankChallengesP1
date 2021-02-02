using System;
using System.Collections.Generic;
using System.Text;

namespace hackerrank2
{
    class LeftRotation
    {
        public static int[] ShiftLeft(int[] arr, int x)
        {
            int[] ShiftedArray = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                ShiftedArray[i] = arr[x];
                x += 1;
                if (x > arr.Length - 1) x = 0;

            }

            return ShiftedArray;
        }
    }
}
