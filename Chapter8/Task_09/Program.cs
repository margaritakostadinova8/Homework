using System;

namespace Task_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the binary number: ");
            string binary = Console.ReadLine();
            Console.WriteLine("{0} to hexadecimal is {1}.", binary, Convert.ToInt32(binary, 2).ToString("X"));
        }
    }
}
/* 9. Да се напише програма, която преобразува двоично число в шестнадесетично.*/
