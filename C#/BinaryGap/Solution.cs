using System;
using System.Collections.Generic;

namespace BinaryGap
{
    internal class Solution
    {
        public int solution(int N)
        {
            int rem = 0;
            double intV = N;
            List<int> Results = new List<int>();

            do
            {
                rem = (int)intV % 2;
                intV = intV / 2;
                Results.Add(rem);
            } while (intV >= 1);
            

            if (Results.Count <= 2)
                return 0;

            int iMaxBinaryGap = 0;
            int prevValue = 0;
            int iCount = 0;
            int iCountHighBits = 0;
            bool bStartCount = false;

            foreach (int x in Results)
            {
                if (iCount > 0)
                {
                    if (prevValue == 1 && x == 0)
                    {
                        bStartCount = true;
                        iCountHighBits++;
                    }
                    else if (prevValue == 0 && x == 1)
                    {
                        iMaxBinaryGap = iMaxBinaryGap > iCountHighBits ? iMaxBinaryGap : iCountHighBits;
                        iCountHighBits = 0;
                        bStartCount = false;
                    }
                    else if (bStartCount == true)
                    { iCountHighBits++; }

                }
                prevValue = x;
                iCount++;
            }

            return iMaxBinaryGap;
        }
    }
}