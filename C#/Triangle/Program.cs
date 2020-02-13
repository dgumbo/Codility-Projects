using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sl = new Solution();

            //int Index = sl.solution(new int[] { 6, 0, 0, -4, 10, -7, -5, -5, -4, -7 });


            //int Index = sl.solution(new int[] { 10, 10, 10 }); 
            // int Index = sl.solution(new int[] { -5, -6, -4, -7, -10 });
           // int Index = sl.solution(new int[] { 4, 7, 3, 2, 1, -3, -5 });
            int Index = sl.solution(new int[] { 5, 3, 3 });

            string arrValues = "";
            //    for (int x = 0; x < Index.GetLength(0); x++)                           arrValues += Index[x].ToString() + ", ";
            arrValues = Index.ToString();

            Console.WriteLine(arrValues);

            Console.WriteLine("\n\nPress Enter to exit");
            Console.ReadLine();
        }
        }
}


// write your code in C# 6.0 with .NET 4.5 (Mono)

