using System;

namespace Task_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("S={0}, P={1}", a * b, (a + b) * 2);
        }
    }
}
/* 6. Напишете програма, която за подадени от потребителя дължина и
височина на правоъгълник пресмята и отпечатва на конзолата неговия
периметър и лице. */
