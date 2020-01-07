using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrefixSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sl = new Solution();

            int Index = sl.solution(new int[] { 2, 2, 1, 0,1 });

            Console.WriteLine(Index.ToString());

            Console.WriteLine("\n\nPress Enter to exit");
            Console.ReadLine();
        }
    }
}
