using System;

namespace Task_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your binary number: ");
            int n = int.Parse(Console.ReadLine());
            string toDecimal = Convert.ToString(Convert.ToInt32(n, 2), 10);
            Console.WriteLine("The result is {0}", toDecimal);
        }
    }
}
/* 13. Напишете програма, която преобразува дадено число от двоична в
десетична бройна система.*/
