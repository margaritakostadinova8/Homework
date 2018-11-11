using System;

namespace Task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            decimal n = int.Parse(Console.ReadLine());
            int zeroes = 0;

            for (int i = (int)(n - 1); i > 0; i--)
                n *= i;

            Console.Write("N! is {0} and it ends ", n);

            do
            {
                n /= 10;
                zeroes++;
            } while (n % 10 == 0);

            Console.WriteLine("with {0} zeroes.", zeroes);
        }
    }   
}
/* 11. Напишете програма, която пресмята с колко нули завършва
факториелът на дадено число. Примери:
N = 10 -> N! = 3628800 -> 2
N = 20 -> N! = 2432902008176640000 -> 4 */
