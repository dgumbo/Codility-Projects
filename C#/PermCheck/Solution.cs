using System;
using System.Collections.Generic;
using System.Linq;

namespace PermCheck
{
    internal class Solution
    {
        internal int solution(int[] A)
        {
            if (A.Count() == 0) return 0;

            List<int> b = A.ToList();
            b.Sort();

            int IPrev = 0;
            for (int c = 0; c < b.Count; c++)
            {
                int d = b[c];

                if (IPrev + 1 != d) return 0;

                IPrev = b[c];
            }

            return 1;
        }
    }
}