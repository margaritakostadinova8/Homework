using System;

namespace Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("Enter your numbers count:");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.Write("Enter {0} number: ", i + 1);
                sum += int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sum of all numbers is {0}.", sum);
        }
    }
}
/* 10. Напишете програма, която прочита едно цяло число n от конзолата.
След това прочита още n на брой числа от конзолата и отпечатва
тяхната сума.*/
