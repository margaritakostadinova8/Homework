using System;

namespace Task_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first your number:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter your second number:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter your third number:");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Enter your fourth number:");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Enter your fifth number:");
            int e = int.Parse(Console.ReadLine());

            if (a < b) a = b;
            if (a < c) a = c;
            if (a < d) a = d;
            if (a < e) a = e;

            Console.WriteLine("{0} is the biggest number.", a);
        }
    }
}
/* 7. Напишете програма, която намира най-голямото по стойност число
измежду дадени 5 числа.*/
