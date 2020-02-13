using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sl = new Solution();

            //int[] Index = sl.solution(new int[] { 6, 0, 0, -2, 10, -7, -5, -5, -4, -5 }, 15); 
            string arrValues = "";
            //for (int x = 0; x < Index.GetLength(0); x++)
            //{
            //    arrValues += Index[x].ToString() + ", ";
            //}

            int Index = sl.solution(new int[] { 4,3,1,2,6 });

            arrValues += Index.ToString() + ", ";



            Console.WriteLine(arrValues);

            Console.WriteLine("\n\nPress Enter to exit");
            Console.ReadLine();
        }
    }
}
