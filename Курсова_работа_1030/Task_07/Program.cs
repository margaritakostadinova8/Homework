using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter x = ");
            decimal x = decimal.Parse(Console.ReadLine());
            Console.Write("Enter y = ");
            decimal y = decimal.Parse(Console.ReadLine());
            Console.Write("Enter z = ");
            decimal z = decimal.Parse(Console.ReadLine());
            decimal d = (x + y) / ( z + z / ( x + z / (y - x)));
            Console.WriteLine("The result is " + d);
        }
    }
}

/* 4. Да се напишат като аритметични изрази на езика C# следните алгебрични изрази:
 * д)*/