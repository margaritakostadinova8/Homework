using System;

namespace Task_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 1, temp = 1;
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter x: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                temp *= i / x;
                sum += temp;
            }
            Console.WriteLine("The final result is {0}", sum);
        }
    }
}
/* 9. Напишете програма, която за дадени цели числа n и x, пресмята
сумата:*/
