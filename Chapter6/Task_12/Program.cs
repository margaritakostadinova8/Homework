using System;

namespace Task_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number: ");
            int n = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(n, 2);
            Console.WriteLine("Result is {0}", binary);
        }
    }
}
/* 12. Напишете програма, която преобразува дадено число от десетична в
двоична бройна система. */
