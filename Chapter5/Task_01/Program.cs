using System;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first number:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter your second number:");
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                a = a + b;
                b = a - b;
                a = a - b;
            }

            Console.WriteLine("The first number - {0}, the second number - {1}.", a, b);
        }
    }
}

/* 1. Да се напише if-конструкция, която проверява стойността на две
целочислени променливи и разменя техните стойности, ако стойността
на първата променлива е по-голяма от втората.*/
