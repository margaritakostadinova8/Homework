using System;

namespace Task_04
{
    class Program
    {
       static bool IsPointIn(double x, double y, double r)
        {
            bool isIn = false;
            double d = Math.Sqrt(Math.Pow((x - 1), 2) + Math.Pow((y - 0), 2));
            isIn = d > r;
            return isIn;
        }
       static void Main(string[] args)
        {
            Console.Write("Enter the x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter the y: ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Enter the r: ");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("{0} , the point is outsiede", IsPointIn(x, y, r));
        }
    }
}
/* 4. 35. Запишете отношение, което е истина при изпълнение на указание условия и лъжа в противен случай:
 в) точката (x,y) се намира извън кръга с радиус r и центът точка (1,0)
 */
