using System;

namespace Task_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N: (1<K<N) ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter K: (1<K<N) ");
            int k = int.Parse(Console.ReadLine());

            for (int i = n - 1; i > 0; i--)
            {
                n *= i;
            }

            for (int i = k - 1; i > 0; i--)
            {
                k *= i;
            }

            n /= k;
            Console.WriteLine("The final result is {0}", n);
        }
    }
}
/* 6. Напишете програма, която пресмята N!/K! за дадени N и K (1<K<N).*/
