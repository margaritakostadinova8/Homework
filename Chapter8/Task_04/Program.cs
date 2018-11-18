using System;

namespace Task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the decimal number: ");
            int deci = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} to binary is {1}.", deci, Convert.ToDecimal(deci));
        }
    }
}
/* 4. Да се напише програма, която преобразува десетично число в двоично.*/
