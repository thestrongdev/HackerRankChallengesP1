using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hackerrank2
{
    class HrGlassArr
    {
        public static int SumHourglass(int[,] arr)
        {
            int[] differentSums = new int[16];

            int differentSumCount = 0;

            int currentSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {

                    if (j < 4 && i < 4)
                    {
                        currentSum = arr[i, j] + arr[i, j + 1] + arr[i, j + 2] + arr[i + 1, j + 1] + arr[i + 2, j] + arr[i + 2, j + 1] + arr[i + 2, j + 2];
                        differentSums[differentSumCount] = currentSum;
                        differentSumCount += 1;
                    }
                }

            }

            return differentSums.ToList().Max();
        }

        public static int SumHourglass(int[][] arr)
        {
            int[] differentSums = new int[16];

            int differentSumCount = 0;

            int currentSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {

                    if (j < 4 && i < 4)
                    {
                        currentSum = arr[i][j] + arr[i] [j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                        differentSums[differentSumCount] = currentSum;
                        differentSumCount += 1;
                    }
                }

            }

            return differentSums.ToList().Max();
        }
    }
}
