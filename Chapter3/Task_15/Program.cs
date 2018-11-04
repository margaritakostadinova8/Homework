using System;

namespace Task_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int v = int.Parse(Console.ReadLine());
            int intvalue1 = 1 << 3;
            int bit3 = (v & intvalue1) != 0 ? 1 : 0;
            intvalue1 = 1 << 4;
            int bit4 = (v & intvalue1) != 0 ? 1 : 0;
            intvalue1 = 1 << 5;
            int bit5 = (v & intvalue1) != 0 ? 1 : 0;
            intvalue1 = 1 << 24;
            int bit24 = (v & intvalue1) != 0 ? 1 : 0;
            intvalue1 = 1 << 25;
            int bit25 = (v & intvalue1) != 0 ? 1 : 0;
            intvalue1 = 1 << 26;
            int bit26 = (v & intvalue1) != 0 ? 1 : 0;

            v = (bit3 == 0) ? v = v & (~(1 << 24)) : v = v | (1 << 24);
            v = (bit4 == 0) ? v = v & (~(1 << 25)) : v = v | (1 << 25);
            v = (bit5 == 0) ? v = v & (~(1 << 26)) : v = v | (1 << 26);
            v = (bit24 == 0) ? v = v & (~(1 << 3)) : v = v | (1 << 3);
            v = (bit25 == 0) ? v = v & (~(1 << 4)) : v = v | (1 << 4);
            v = (bit26 == 0) ? v = v & (~(1 << 5)) : v = v | (1 << 5);

            Console.WriteLine(v); 
        }
    }
}
/* 15. Напишете програма, която разменя стойностите на битовете на
позиции 3, 4 и 5 с битовете на позиции 24, 25 и 26 на дадено цяло
положително число.*/
