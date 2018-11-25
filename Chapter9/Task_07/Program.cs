﻿using System;

namespace Task_07
{
    class Program
    {
        public static string Reverse(string number)
        {
            char[] charArray = number.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter your number: ");
            string number = Console.ReadLine();

            Console.WriteLine(Reverse(number));
        }
    }
}
/* 7. Напишете метод, който отпечатва цифрите на дадено десетично число
в обратен ред. Например 256 трябва да бъде отпечатано като 652. */
