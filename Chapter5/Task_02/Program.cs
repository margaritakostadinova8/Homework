using System;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first number:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter your second number:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter your third number:");
            int c = int.Parse(Console.ReadLine());

            if (a < 0 && b < 0 && c < 0) Console.WriteLine("-");
            else if (a >= 0 && b >= 0 && c >= 0) Console.WriteLine("+");
            else if (a < 0 && b < 0 && c >= 0) Console.WriteLine("+");
            else if (a < 0 && b >= 0 && c < 0) Console.WriteLine("+");
            else if (a >= 0 && b < 0 && c < 0) Console.WriteLine("+");
            else if (a < 0 && b >= 0 && c >= 0) Console.WriteLine("-");
            else if (a >= 0 && b < 0 && c >= 0) Console.WriteLine("-");
            else if (a >= 0 && b >= 0 && c < 0) Console.WriteLine("-");
        }
    }
}
/* 2. Напишете програма, която показва знака (+ или -) от произведението
на три реални числа, без да го пресмята. Използвайте
последователност от if оператори.*/
