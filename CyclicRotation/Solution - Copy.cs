using System;
using System.Collections.Generic;
using System.Linq;

namespace CyclicRotation
{
    public class Solution1
    {
        //public int[] solution(int[] A, int K)
        //{
        //    int arrSize = A.Length;

        //    if (arrSize <= 1) return A;

        //    if (K > arrSize) K = K % arrSize;

        //    List<int> li = A.ToList();

        //    for (int x = 0; x < K; ++x)
        //    {
        //        int y = li[arrSize - 1];

        //        li.RemoveAt(arrSize - 1);
        //        li.Insert(0, y);
        //    }

        //    return li.ToArray<int>();
        //}

        public int[] solution(int[] A, int K)
        {
            int N = A.Length;
            if (N == 0) return A;
            if (K >= N) K %= N;
            if (K == 0) return A;

            int[] rotA = new int[N];

            for (int i = 0; i < N; i++)
                rotA[i] = (i < K) ? A[N + i - K] : A[i - K];

            return rotA;
        }
    }
}