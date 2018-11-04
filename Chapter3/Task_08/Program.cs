using System;

namespace Task_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter your y: ");
            int y = int.Parse(Console.ReadLine());
            bool boolvalue1 = (x * x + y * y <= 5) ? true : false;
            Console.WriteLine("The point O({0},{1}) is inside K((0,0),5)?: {2}", x, y, boolvalue1);
        }
    }
}
/* 8. Напишете програма, която проверява дали дадена точка О (x, y) е
вътре в окръжността К ((0,0), 5). Пояснение: точката (0,0) е център на
окръжността, а радиусът й е 5.*/
