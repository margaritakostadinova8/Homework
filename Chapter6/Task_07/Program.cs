using System;

namespace Task_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N: (1<K<N) ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter K: (1<K<N) ");
            int k = int.Parse(Console.ReadLine());
            int nMinusK = n - k;

            for (int i = n - 1; i > 0; i--) n *= i;
            for (int i = k - 1; i > 0; i--) k *= i;
            for (int i = nMinusK - 1; i > 0; i--) nMinusK *= i;

            Console.WriteLine("The final result is {0}", n * k / nMinusK);
        }
    }
}
/* 7. Напишете програма, която пресмята N!*K!/(N-K)! за дадени N и K
(1<K<N).*/
