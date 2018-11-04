using System;

namespace Task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            Console.Write("Enter number:");
            int count = int.Parse(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}

/* 11. Напишете програма, която прочита цяло число n от конзолата и
отпечатва на конзолата всички числа в интервала [1…n], всяко на
отделен ред.*/
