using System;
using System.Linq;
using System.Collections.Generic;

namespace OddOccurrencesInArray
{
    internal class Solution
    {
        public int solution(int[] A)
        {


            // write your code in C# 6.0 with .NET 4.5 (Mono)
            List<int>  newA = A.OrderBy(i => i).ToList();
             
            for (int j = 0; j <= newA.Count - 2; j++) {
                int iNow = newA[j];
                int iNext = newA[j + 1];

                if (iNow != iNext) {
                    return iNow; 
                }
                j += 1;
            }

            return newA[newA.Count - 1];
        }
    }
}