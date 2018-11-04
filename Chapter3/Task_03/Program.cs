using System;

namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number with at least 5 digits:");
            int number = int.Parse(Console.ReadLine());
            bool boolvalue1 = (number / 100) % 10 == 7 ? true : false;
            Console.WriteLine("Is the third digit of {0}, 7 ? {1}", number, boolvalue1);
        }
    }
}

// 3. Напишете израз, който да проверява дали третата цифра (отдясно на ляво) на дадено цяло число е 7.