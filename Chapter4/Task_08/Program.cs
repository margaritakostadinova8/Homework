using System;

namespace Task_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first number");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter your second number");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter your third number");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Enter your fourth number");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Enter your fifth number");
            int e = int.Parse(Console.ReadLine());

            if (a > b && a > c && a > d && a > e) Console.WriteLine("{0} is the biggest of them all.", a);
            else if (b > a && b > c && b > d && b > e) Console.WriteLine("{0} is the biggest.", b);
            else if (c > a && c > b && c > d && c > e) Console.WriteLine("{0} is the biggest.", c);
            else if (d > a && d > b && d > c && d > e) Console.WriteLine("{0} is the biggest.", d);
            else if (e > a && e > b && e > c && e > d) Console.WriteLine("{0} is the biggest.", e);
            else Console.WriteLine("All the numbers are equal!");
        }
    }
}
// 8. Напишете програма, която чете пет числа от конзолата и отпечатва най-голямото от тях