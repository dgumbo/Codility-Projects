using System;
using System.Linq;

namespace Triangle
{
    internal class Solution
    {
        internal int solution(int[] A)
        {
            A = A.OrderBy(i => i).ToArray();

            for (int j = 0; j < A.Length - 2; j++)
            {
                if ((Int64)A[j] + (Int64)A[j + 1] > (Int64)A[j + 2]
                && (Int64)A[j + 1] + (Int64)A[j + 2] > (Int64)A[j]
                && (Int64)A[j + 2] + (Int64)A[j] > (Int64)A[j + 1]) return 1;
            }

            return 0;
        }
    }
}