using System;

namespace Task_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} >= {1}", Math.Max(a, b), Math.Min(a, b));
        }
    }
}
/* 6. Напишете програма, която чете две числа от конзолата и отпечатва поголямото
от тях. Решете задачата без да използвате условни
конструкции. */
