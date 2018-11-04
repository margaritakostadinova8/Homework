using System;

namespace Task_09
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
            bool boolvalue2 = (x < -1 && x > 5 && y < 1 && y > 5) ? true : false;
            Console.WriteLine("The point O({0},{1}) is outside rectangle ((-1, 1), (5, 5)?: {2}", x, y, boolvalue2);
        }
    }
}
/* 9. Напишете програма, която проверява дали дадена точка О (x, y) е
вътре в окръжността К ((0,0), 5) и едновременно с това извън правоъгълника
((-1, 1), (5, 5)). Пояснение: правоъгълникът е зададен чрез
координатите на долния си ляв и горния си десен ъгъл.*/
