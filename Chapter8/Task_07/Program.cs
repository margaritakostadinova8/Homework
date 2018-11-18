using System;

namespace Task_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the hexadecimal number: ");
            string hexa = Console.ReadLine();
            Console.WriteLine("{0} to decimal is {1}.", hexa, Convert.ToInt32(hexa, 16));
        }
    }
}
/* 7. Да се напише програма, която преобразува шестнадесетично число в
десетично.*/
