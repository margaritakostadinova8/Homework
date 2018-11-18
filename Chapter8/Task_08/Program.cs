using System;

namespace Task_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the hexadecimal number: ");
            string hexa = Console.ReadLine();
            Console.WriteLine("{0} to binary is {1}.", hexa, Convert.ToString(Convert.ToInt32(hexa, 16), 2));
        }
    }
}
/* 8. Да се напише програма, която преобразува шестнадесетично число в
двоично.*/
