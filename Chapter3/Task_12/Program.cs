using System;

namespace Task_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = 5;
            int p = 1;
            int intvalue1 = 1 << p;
            bool boolvalue1 = (v & intvalue1) != 0 ? true : false;
            Console.WriteLine("The bit at position {0}of number {1} is 1? {2}", p, v, boolvalue1);
        }
    }
}
/* 12. Напишете булев израз, който проверява дали битът на позиция p на
цялото число v има стойност 1. Пример v=5, p=1 -> false.*/
