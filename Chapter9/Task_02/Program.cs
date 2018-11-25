using System;

namespace Task_02
{
    class Program
    {
        static int value1;

        static void GetMax(int first, int second)
        {
            if (first > second) value1 = first;
            else value1 = second;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter your first number: ");
            value1 = int.Parse(Console.ReadLine());
            Console.Write("Enter your second number: ");
            int value2 = int.Parse(Console.ReadLine());
            Console.Write("Enter your third number: ");
            int value3 = int.Parse(Console.ReadLine());

            GetMax(value1, value2);
            GetMax(value1, value3);

            Console.WriteLine("The biggest number is {0}", value1);
        }
    }
}
/* 2. Създайте метод GetMax() с два целочислени (int) параметъра, който
връща по-голямото от двете числа. Напишете програма, която прочита
три цели числа от конзолата и отпечатва най-голямото от тях, използвайки
метода GetMax().*/
