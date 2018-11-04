using System;

namespace Task_09
{
    class Program
    {
        static void Main(string[] args)
        {
            double d, x1, x2;
            Console.Write("Enter A (A must be different to 0!): ");
            double a = int.Parse(Console.ReadLine());
            Console.Write("Enter B:");
            double b = int.Parse(Console.ReadLine());
            Console.Write("Enter C:");
            double c = int.Parse(Console.ReadLine());

            d = b * b - 4 * a * c;

            if (d < 0) Console.WriteLine("D={0}, There are no real roots.", d);
            else if (d == 0)
            {
                x1 = (-b / (2 * a));
                Console.WriteLine("X={0}", x1);
            }
            else
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("X1={0}, X2={1}", x1, x2);
            }
        }
    }
}

/* 9. Напишете програма, която чете коефициентите a, b и c от конзолата и
решава уравнението: ax2+bx+c=0. Програмата трябва да принтира
реалните решения на уравнението на конзолата. */
                                                