using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TapeEquilibrium
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sl = new Solution();

            int Index = sl.solution(new int[] { 3,1,2,4,3 });

            string arrValues = "";
            //    for (int x = 0; x < Index.GetLength(0); x++)   arrValues += Index[x].ToString() + ", ";
            arrValues = Index.ToString();

            Console.WriteLine(arrValues);

            Console.WriteLine("\n\nPress Enter to exit");
            Console.ReadLine();
        }
    }
}
