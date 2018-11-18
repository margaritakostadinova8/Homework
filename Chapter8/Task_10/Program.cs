using System;

namespace Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int deci = 0;

            Console.Write("Enter the binary number: ");
            string binary = Console.ReadLine();
            int length = binary.Length;
            int power = length - 1;

            for (int i = 0; i < length; i++)
            {
                deci += (int)(int.Parse(binary[i].ToString()) * Math.Pow(2, power));
                power--;
            }

            Console.WriteLine("The result is {0}.", deci);
        }
    }
}
/* 10. Да се напише програма, която преобразува двоично число в десетично
по схемата на Хорнер.*/
