using System;

namespace Task_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstN = 0, secondN = 1, thirdN = 0;

            Console.Write("Enter N: ");
            int length = int.Parse(Console.ReadLine());

            Console.Write("0, 1,");

            for (int i = 2; i < length; i++)
            {
                thirdN = firstN + secondN;
                Console.Write(" {0},", thirdN);
                firstN = secondN;
                secondN = thirdN;
            }
        }
    }
}
/* 5. Напишете програма, която чете от конзолата числото N и отпечатва
сумата на първите N члена от редицата на Фибоначи: 0, 1, 1, 2, 3, 5, 8,
13, 21, 34, 55, 89, 144, 233, 377, ... */
