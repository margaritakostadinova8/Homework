using System;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 2030;
            Console.WriteLine("Value: " + value);
            string binary = Convert.ToString(value, 2);
            Console.WriteLine("The value in binary: " + binary);
            string octal = Convert.ToString(value, 8);
            Console.WriteLine("The value in octal: " + octal);
            string hexadecimal = Convert.ToString(value, 16);
            Console.WriteLine("The value in octal: " + hexadecimal);
            /*Създаваме стринг и използваме опция Convert.ToString,в която въвеждаме числото и базата, на която искаме 
             * да го превърнем.*/
        }
    }
}

// 1. Преварнете 2030 в 2, 8 и 16 тична.