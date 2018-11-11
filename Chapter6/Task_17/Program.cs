using System;

namespace Task_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter your second number: ");
            int b = int.Parse(Console.ReadLine());

            while (a != 0 && b != 0)
            {
                if (a > b) a %= b;
                else b %= a;
            }

            if (a == 0) Console.WriteLine(b);
            else Console.WriteLine(a);
        }
    }
}
/* 17. Напишете програма, която за дадени две числа, намира най-големия
им общ делител.*/
