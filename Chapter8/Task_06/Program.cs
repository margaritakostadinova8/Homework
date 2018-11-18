using System;

namespace Task_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the decimal number: ");
            int deci = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} to hexadecimal is {1}.", deci, deci.ToString("X"));
        }
    }
}
/* 6. Да се напише програма, която преобразува десетично число в
шестнадесетично.*/
