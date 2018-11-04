using System;

namespace Task_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int invalue1 = 2;
            int invalue2 = 3;
            invalue1 = invalue1 + invalue2;
            invalue2 = invalue1 - invalue2;
            invalue1 = invalue1 - invalue2;
            Console.WriteLine("invalue1:{0} invalue2:{1}", invalue1, invalue2);

        }
    }
}
/* 13. Декларирайте две променливи от тип int. Задайте им стойности съответно 5 и 10. 
Разменете стойностите им и ги отпечатайте. */


