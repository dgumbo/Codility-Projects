using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryGap
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sl = new Solution();

            int Index = sl.solution(2147483617);

            Console.WriteLine(Index.ToString());

            Console.WriteLine("\n\nPress Enter to exit");
            Console.ReadLine();
        }
    }
}
