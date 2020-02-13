using System;

namespace Fish
{
    internal class Solution2222
    { 
        internal int solution(int[] A, int[] B)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            int n = A.Length;

            int iTotalFish = n;
            for (int a = 0; a <= n - 1; a++)
            {
                int fSize = A[a];
                int fDir = B[a];

                if (fDir == 1)
                {
                    for (int i = a + 1; i < n; i++)
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
                            break;
                        }
                    }
                }
                else
                {
                    for (int i = a - 1; i >= 0; i--)
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
                            break;
                        }
                    }
                }
            }

            return iTotalFish;
        }
    }
}