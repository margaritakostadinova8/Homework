using System;

namespace Task_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first number:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter your second number:");
            int b = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 5 == 0) counter++;
            }
            Console.WriteLine("{0} numbers were found", counter);
        }
    }
}

/* 5. Напишете програма, която чете от конзолата две цели числа (int) и
отпечатва колко числа има между тях, такива, че остатъкът им от
деленето на 5 да е 0. Пример: в интервала (17, 25) има 2 такива числа.*/
