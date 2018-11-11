using System;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first your number:");
            int length = int.Parse(Console.ReadLine());

            for (int i = 1; i < length; i++)
                Console.WriteLine(i);
        }
    }
}
/* 1. Напишете програма, която отпечатва на конзолата числата от 1 до N.
Числото N трябва да се чете от стандартния вход.*/
