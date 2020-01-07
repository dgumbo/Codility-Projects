using System;

namespace SpeedCameras
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sl = new Solution();

            int Index = sl.solution(new int[] { 2, 2, 1, 0, 1 }, new int[] { 2, 2, 1, 0, 1 }, 5);

            Console.WriteLine(Index.ToString());

            Console.WriteLine("\nPress Enter to exit");
            Console.ReadLine();
        }
    }
}
