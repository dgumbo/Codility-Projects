using System.Collections.Generic;
using System.Linq;

namespace PrefixSet
{
    class Solution
    {
        public int solution(int[] A)
        {
            // write your code in Java SE 8

            List<int> liA = A.Distinct().ToList();
            int[] arA = A.Distinct().ToArray();
            int iIndex = 0;
            int iCount = 0;

            for (int i = 0; i < A.GetLength(0); ++i)
            {
                int x = A[i];
                if (liA.Count > 0)
                {
                    foreach (int y in arA)
                    {
                        if (x == y)
                        {
                            iCount++;
                            liA.Remove(y);
                            break;
                        }
                    }
                }
                
                 if (liA.Count == 0)
                {
                    iIndex = i;
                    break;
                }
            }

            return iIndex;
        }
    }
}
