using System;

namespace Task_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int s, d;

            Console.Write("Enter the N: ");
            string n = Console.ReadLine();

            do
            {
                Console.Write("Enter S (S must be 2, 8, 10 or 16): ");
                s = int.Parse(Console.ReadLine());
            } while (s != 2 && s != 8 && s != 10 && s != 16);

            do
            {
                Console.Write("Enter D (D must be 2, 8, 10 or 16): ");
                d = int.Parse(Console.ReadLine());
            } while (d != 2 && d != 8 && d != 10 && d != 16);

            n = Convert.ToString(Convert.ToInt32(n, s), d);

            Console.WriteLine("Result is {0}.", n);
        }
    }
}
/* 13. Да се напише програма, която по зададени N, S, D (2 ≤ S, 16 ≥ D)
преобразува числото N от бройна система с основа S към бройна
система с основа D.*/
