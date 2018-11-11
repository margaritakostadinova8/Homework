using System;

namespace Task_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your decimal number: ");
            int n = int.Parse(Console.ReadLine());
            string toDecimal = Convert.ToString(Convert.ToInt32(n, 16), 10);
            Console.WriteLine("The result is {0}", toDecimal);
        }
    }
}
/* 15. Напишете програма, която преобразува дадено число от шестнайсетична
в десетична бройна система.*/
