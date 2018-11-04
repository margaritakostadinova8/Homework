using System;

namespace Task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("The third bit of {0} is 1? {1}", number, ((number >> 3) & 1) == 1);
        }
    }
}

// 4. Напишете израз, който да проверява дали третият бит на дадено число е 1 или 0.