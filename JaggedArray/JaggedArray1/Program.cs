using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] marks = new int[3][];
            marks[0] =new int[3]{ 100,200,300};
            marks[1] = new int[5] { 400, 500, 600, 700, 800};
            marks[2] = new int[2] { 900, 1000};

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("this is row number "+i);
                for (int j = 0;j < marks[i].Length; j++)
                {
                    Console.WriteLine(marks[i][j]);
                }
            Console.WriteLine();
            }
        }
    }
}
