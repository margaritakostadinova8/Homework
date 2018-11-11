using System;

namespace Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N: (N < 20) ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= i; j++)
                {
                    Console.Write("{0} ", j);
                }
                Console.WriteLine();
            }
        }
    }
}
/* 10. Напишете програма, която чете от конзолата положително цяло число
N (N < 20) и отпечатва матрица с числа като на фигурата по-долу:
N = 3 N = 4 */
