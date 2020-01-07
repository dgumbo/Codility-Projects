using System;

namespace Fish
{
    internal class Solution
    {
        public Solution()
        {
        }

        internal int solution(int[] A, int[] B)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            int n = A.Length;
            int iTotalFish = n;

            int fSize = A[0];
            int fDir = B[0];

            for (int i = 1; i <= n - 1; i++)
            {
                if (fDir == 1)
                {
                    int fnSize = A[i];
                    int fnDir = B[i];

                    if (fDir == fnDir && fSize < fnSize)
                    {
                        fSize = fnSize;
                    }
                    if (fDir != fnDir && fSize < fnSize)
                    {
                        iTotalFish -= 1;
                        fSize = 0;
                    }
                }
                // fSize = A[0];
                fDir = B[i];
            }

            fSize = A[n - 1];
            fDir = B[n - 1];
            for (int i = n - 1; i >= 0; i--)
            {
                if (fDir == 0)
                {
                    int fnSize = A[i];
                    int fnDir = B[i];

                    if (fDir == fnDir && fSize < fnSize)
                    {
                        fSize = fnSize;
                    }
                    if (fDir != fnDir && fSize < fnSize)
                    {
                        iTotalFish -= 1;
                        fSize = 0;
                    }
                }
                fDir = B[i];
            }

            return iTotalFish;
        }
    }
}