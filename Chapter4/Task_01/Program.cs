using System;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number:");
            int number3 = int.Parse(Console.ReadLine());
            int result = number1 + number2 + number3;
            Console.WriteLine("The sum of the three numbers is: " + result);
        }
    }
}

// 1. Напишете програма, която чете от конзолата три числа от тип int и отпечатва тяхната сума.