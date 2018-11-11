using System;

namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first number:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter your second number:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter your third number:");
            int c = int.Parse(Console.ReadLine());

            if (a > b)
                if (a > c) Console.WriteLine("A is the biggest number");
                else if (a < c) Console.WriteLine("C is the biggest number");
                else Console.WriteLine("A and C are the biggest numbers");
            else if (a < b)
                if (b > c) Console.WriteLine("B is the biggest number");
                else if (b < c) Console.WriteLine("C is the biggest number");
                else Console.WriteLine("B and C are the biggest numbers");
            else if (a == b)
                if (a == c) Console.WriteLine("All the numbers are equal");
                else if (a < c) Console.WriteLine("C is the biggest number");
                else Console.WriteLine("A and B are the biggest numbers");
        }
    }
}
/* 3. Напишете програма която намира най-голямото по стойност число, измежду три дадени числа.*/
