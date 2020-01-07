using System;
using System.Collections.Generic;
using System.Linq;

namespace PermMissingElem
{
    internal class Solution
    {
        internal int solution(int[] A)
        {
            if (A.Count() == 0) return 1;

            List<int> b = A.ToList();
            b.Sort();

            int IPrev = 0;
            for (int c = 0; c < b.Count; c++) {
                int d =  b[c];

                if (IPrev + 1 != d) return IPrev + 1;

                IPrev = b[c];
            }

            return IPrev + 1;
        }
    }
}