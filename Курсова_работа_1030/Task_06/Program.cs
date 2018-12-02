using System;

namespace Task_06
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("a=");
            float a = float.Parse(Console.ReadLine());
            Console.Write("b=");
            float b = float.Parse(Console.ReadLine());
            Console.Write("c=");
            float c = float.Parse(Console.ReadLine());
            bool prov;
            if (a > 0 && b > 0 && c > 0 && (a + b) > c && (b + c) > a && (a + c) > b)
            {
                prov = true;
            }
            else
            {
                prov = false;
            }
            double p = (a + b + c) / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            if (prov == true)
            {
                Console.WriteLine("S= " + S);
            }
            else
            {
                Console.WriteLine("A trinagle with this parameters does not exist!");
            }
        }
    }
}
/* 6. 165. При зададени дължини на 3 страни да се напишат методи за:
а) проверка дали съществува триъгълник с такива страни
б) намиране на лицето му, когато стойността на предишната е true*/
