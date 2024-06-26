//3) Write a program to accept 5 marks from the user and
//calculate their sum using Console Application.

using System;

namespace _22Assignments
{
    internal class Sum
    {
        public void Berij() 
        {
            Console.WriteLine("Enter the 5 numbers");
            int num1=int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            int num5 = int.Parse(Console.ReadLine());

            int sum = num1+ num2+ num3+ num4+ num5;
            Console.WriteLine($"sum of given nmbers is {sum}");
        }
    }
}
