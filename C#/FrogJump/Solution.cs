using System;

namespace FrogJump
{
    internal class Solution
    {
        public int solution(int X, int Y, int D)
        {
            if (X >= Y) return 0;
            if (D >= Y - X) return 1;
            if (D == 1) return Y - X ; 

            return ( (Y - X) / D )  + ( (Y - X) % D == 0 ? 0 : 1 );
        }
    }
}