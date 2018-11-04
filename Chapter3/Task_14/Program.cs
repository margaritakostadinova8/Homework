using System;

namespace Task_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            bool boolvalue1 = true;
            if (number > 2)
                for (int i = 2; i <= Math.Ceiling(Math.Sqrt(number)); ++i)
                {
                    if (number % i == 0) boolvalue1 = false;
                }
            Console.WriteLine("{0} is prime?: {1}", number, boolvalue1);
        }
    }
}
/* 14. . Напишете програма, която проверява дали дадено число n (1 < n < 100)
е просто (т.е. се дели без остатък само на себе си и на единица). */
