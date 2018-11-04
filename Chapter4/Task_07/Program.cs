using System;

namespace Task_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e;
            bool incorrect = false;
            do
            {
                Console.Write("Enter your first number");
                incorrect = int.TryParse(Console.ReadLine(), out a);
                Console.WriteLine(incorrect);
            } while (!incorrect);
            do
            {
                Console.Write("Enter your second number");
                incorrect = int.TryParse(Console.ReadLine(), out b);
                Console.WriteLine(incorrect);
            } while (!incorrect);
            do
            {
                Console.Write("Enter your third number");
                incorrect = int.TryParse(Console.ReadLine(), out c);
                Console.WriteLine(incorrect);
            } while (!incorrect);
            do
            {
                Console.Write("Enter your fourth number");
                incorrect = int.TryParse(Console.ReadLine(), out d);
                Console.WriteLine(incorrect);
            } while (!incorrect);
            do
            {
                Console.Write("Enter fifth number");
                incorrect = int.TryParse(Console.ReadLine(), out e);
                Console.WriteLine(incorrect);
            } while (!incorrect);
        }
    }
}
/* 7. Напишете програма, която чете пет числа и отпечатва тяхната сума.
При невалидно въведено число да се подкани потребителя да въведе
друго число. */
