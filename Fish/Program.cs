using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fish
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sl = new Solution();

            //int Index = sl.solution(new int[] { 6, 0, 0, -4, 10, -7, -5, -5, -4, -7 });

            // int Index = sl.solution("{[()()]}");
            int Index = sl.solution(new int[] { 4, 3, 2, 1, 5 }, new int[] { 0, 1, 0, 0, 0 }) ;

            string arrValues = "";
            //    for (int x = 0; x < Index.GetLength(0); x++)                           arrValues += Index[x].ToString() + ", ";
            arrValues = Index.ToString();

            Console.WriteLine(arrValues);

            Console.WriteLine("\n\nPress Enter to exit");
            Console.ReadLine();
        }
    }
}
