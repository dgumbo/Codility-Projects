using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MaxProductOfThree
{
    internal class Solution
    { 

        internal int solution(int[] A)
        {
            A = A.OrderBy( i => i ).ToArray();

            int a = A[A.Length - 1] * A[A.Length - 2] * A[A.Length - 3];
            int b = A[0   ]   * A[1] *  A[2   ] ;
            int c = A[A.Length - 1] * A[A.Length - 2] * A[0];
            int d = A[A.Length - 1] * A[0] * A[1];

            int[] B = (new int[]{a,b,c,d }).OrderBy(k=>k).ToArray();

            return B[3];


        }
    }
}