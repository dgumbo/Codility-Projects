using System;

namespace NumberOfDiscIntersections
{
    internal class Solution
    {
        internal int solution(int[] A)
        {
            int n = A.Length;

            int iCounter = 0;
            for (int a = 0; a < n - 1; a++)
            {
                for (int b = a+1; b < n; b++)
                {
                    if (a != b)
                    {
                        Int64 t1Min = a - A[a];
                        Int64 t1Max = a + A[a];

                        Int64 t2Min = b - A[b];
                        Int64 t2Max = b + A[b];

                        if (t2Min <= t1Max & t1Max <= t2Max )
                        {
                            iCounter += 1;
                        }
                        else if (t1Min <= t2Max & t2Max <= t1Max )
                        {
                            iCounter += 1;
                        }
                        else if (t1Min == a | t1Max == b)
                        {
                            iCounter += 1;
                        }
                        else if (t1Min == a | t1Max == b)
                        {
                            iCounter += 1;
                        }
                    }
                    if (iCounter > 10000000) return -1;
                }
            }

            return iCounter;
        }
    }
}