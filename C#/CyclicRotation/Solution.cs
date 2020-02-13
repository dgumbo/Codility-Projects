using System;
using System.Collections.Generic;
using System.Linq;

namespace CyclicRotation
{
    public class Solution
    {
        internal int[] solution(int[] A, int K)
        {
            if (A.Length == 0 || A.Length == 1 || A.Length == K || K == 0) return A;

            int newK = K > A.Length ? K % A.Length : K;

            int[] newA = new int[A.Length];
            for (int y = 0; y <= A.Length - 1; y++) {
                int p = y - newK < 0 ? y - newK + A.Length : y - newK ; 

                newA[y] = A[p];
            }

            return newA;
        }
    }
}