using System;

namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal decimalvalue1 = 1.2416552345213m;
            decimal decimalvalue2 = 8.2421476423756m;
            decimalvalue1 += decimalvalue2;
            Console.WriteLine(decimalvalue1.ToString("#.######"));
        }
    }
}
// 3. Напишете програма, която изчислява вярно променливи с плаваща запетая с точност до 0.000001.