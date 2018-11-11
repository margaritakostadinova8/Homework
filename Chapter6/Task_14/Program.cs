using System;

namespace Task_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your decimal number: ");
            int n = int.Parse(Console.ReadLine());
            string toDecimal = Convert.ToString(Convert.ToInt32(n, 10), 16);
            Console.WriteLine("The result is {0}", toDecimal);
        }
    }
}
/* 14. Напишете програма, която преобразува дадено число от десетична в
шестнайсетична бройна система. */
