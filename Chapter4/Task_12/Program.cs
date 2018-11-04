using System;

namespace Task_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 0;
            int number2 = 1;
            int sum = 1;
            int count = 0;

            Console.WriteLine(number1);

            while (count < 100)
            {
                sum = number1 + number2;
                number1 = number2;
                number2 = sum;
                Console.WriteLine(number2);
                count++;
            }
        }
    }
}
/* 12. Напишете програма, която отпечатва на конзолата първите 100 числа
от редицата на Фибоначи: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144,
233, 377, ... */
