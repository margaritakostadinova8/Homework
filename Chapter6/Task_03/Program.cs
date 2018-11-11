using System;

namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowest = 0, highest = 0, input;

            Console.Write("Enter your numbers length: ");
            int lenght = int.Parse(Console.ReadLine());

            for (int i = 0; i < lenght; i++)
            {
                Console.Write("Enter number: ");
                input = int.Parse(Console.ReadLine());
                if (i == 0) lowest = highest = input;
                else
                {
                    if (lowest > input) lowest = input;
                    if (highest < input) highest = input;
                }
            }
            Console.WriteLine("Lowest - {0}, Highest - {1}", lowest, highest);
        }
    }
}
/* 3. Напишете програма, която чете от конзолата поредица от цели числа и
отпечатва най-малкото и най-голямото от тях.*/
