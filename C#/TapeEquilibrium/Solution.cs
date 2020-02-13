using System;
using System.Linq;

namespace TapeEquilibrium
{
    internal class Solution
    {
        //    internal int solution(int[] A)
        //    {
        //        if (A.Count() <= 1) return 0;
        //        if (A.Count() == 2) return A[1] > A[0] ? A[1] - A[0] : A[0] - A[1];

        //        int iDiff = 100000000;
        //        for (int x = 1; x < A.Count() - 1; x++)
        //        {
        //            Int32 iSumLower = 0;
        //            Int32 iSumUpper = 0;
        //            for (int y = 0; y < A.Count(); y++)
        //            {
        //                if (y > x) { iSumLower += A[y]; }
        //                else { iSumUpper += A[y]; }
        //            }
        //            int iTemp = iSumLower > iSumUpper ? iSumLower - iSumUpper : iSumUpper - iSumLower;
        //            iDiff = iTemp < iDiff ? iTemp : iDiff;
        //        }

        //        return iDiff;
        //    }

        internal int solution(int[] A)
        {
            if (A.Count() <= 1) return 0;
            if (A.Count() == 2) return A[1] > A[0] ? A[1] - A[0] : A[0] - A[1];

            int iDiff = 100000000;

            Int32 iSumTotal = 0;
            for (int y = 0; y < A.Count(); y++)
            {
                iSumTotal += A[y];
            }
                Int32 iSumLower = A[0];
                Int32 iSumUpper = 0;

            for (int x = 1; x < A.Count() - 1; x++)
            {
                iSumLower += A[x]; 

                iSumUpper = iSumTotal - iSumLower;


                int iTemp = iSumLower > iSumUpper ? iSumLower - iSumUpper : iSumUpper - iSumLower;
                iDiff = iTemp < iDiff ? iTemp : iDiff;
            }

            return iDiff;
        }
    }
}