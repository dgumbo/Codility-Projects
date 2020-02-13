using System;
using System.Collections.Generic;
using System.Linq;

namespace BracketSequence
{
    internal class Solution
    {
        internal int solution(string S, int K)
        {
            if (S.Length <= 1) return 0;
            if (S.Length == 2 && K >= 2) return 1;
            if (S.Length == 3 && K >= 1) return 1;


            int rem = 0;
            List<char> sArr = S.ToCharArray().ToList();
            int iCount = sArr.Count;

            List<int> bBracketLevel = new List<int>();

            char prevBrac = new char();
            
            
            int iCountBrackets = 0;
            bool bCount = false;


          //  for (int x = 1; x <= K; x++)
            {
                for (int y = 0; y < sArr.Count; y++)
                {
                    char currBrack = sArr[y];
                    if (currBrack == '(' && bBracketLevel.Count == 0)
                    {
                        bBracketLevel.Add(1);
                    }
                    else   if (currBrack == '(' && bBracketLevel.Count >= 1)
                    {
                        bBracketLevel.Add(bBracketLevel.Count + 1);
                    }
                    else if (currBrack == ')' && bBracketLevel.Count > 1)
                    {
                        int z = bBracketLevel[bBracketLevel.Count - 1];
                        bBracketLevel.Remove(z);
                    }
                    else if (currBrack == ')' && bBracketLevel.Count == 1)
                    {
                        iCountBrackets += 1;

                        int z = bBracketLevel[bBracketLevel.Count - 1];
                        bBracketLevel.Remove(z);
                    }                    

                    prevBrac = sArr[y];
                }
            }

                        

            return iCountBrackets;
        }
    }
}