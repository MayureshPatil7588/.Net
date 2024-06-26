//2) Write a program to accept 5 marks from the user and
//  calculate their average using Console Application.

using System;

namespace _22Assignments
{
    internal class marksavg
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("please enter the 5 numbers");
        //    int num1 = int.Parse(Console.ReadLine());
        //    int num2 = int.Parse(Console.ReadLine());
        //    int num3 = int.Parse(Console.ReadLine());
        //    int num4 = int.Parse(Console.ReadLine());
        //    int num5 = int.Parse(Console.ReadLine());

        //    int avg = (num1 + num2 + num3 + num4 + num5) / 5;
        //    Console.WriteLine($"the average of numer that you have given is {avg}!");

        //}

         public void AcceptMarks()
        {
            Console.WriteLine("please enter the 5 numbers");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            int num5 = int.Parse(Console.ReadLine());

            int avg = (num1 + num2 + num3 + num4 + num5) / 5;
            Console.WriteLine($"the average of numer that you have given is {avg}!");

        }
    }
}
