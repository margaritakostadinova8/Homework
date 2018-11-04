using System;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius:" );
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("P is {0} and S is {1}", 2 * Math.PI * r, Math.PI * r * r);
        }
    }
}
// 2. Напишете програма, която чете от конзолата радиуса "r" на кръг и отпечатва неговото лице и обиколка.