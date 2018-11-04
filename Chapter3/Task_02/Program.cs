using System;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number:");
            int number = int.Parse(Console.ReadLine());
            bool boolvalue1 = number % 35 == 0 ? true : false;
            Console.WriteLine("{0} is divisible by both 5 and 7? {1}", number, boolvalue1);
        }
    }
}

// 2. Напишете булев израз, който да проверява дали дадено цяло число се дели на 5 и на 7 без остатък.