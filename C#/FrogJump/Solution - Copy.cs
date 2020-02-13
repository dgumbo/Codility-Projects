using System;

namespace FrogJump
{
    internal class Solution2
    {
        public int solutidon(int X, int Y, int D)
        {
            if (X >= Y) return 0;
            if (D > Y) return 0;

            int iCount = ((Y - X) / D) + ((Y - X) % D == 0 ? 0 : 1);
            return iCount;
        }
    }
}