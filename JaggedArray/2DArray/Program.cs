using System;

namespace _2DArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] twoArr = new int[2, 2] { { 1, 2 }, { 1, 2 } };
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(twoArr[i, j]+" ");
                }
                Console.WriteLine("");
            }
        }
    }
}
