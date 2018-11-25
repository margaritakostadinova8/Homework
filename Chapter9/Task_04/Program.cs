using System;

namespace Task_04
{
    class Program
    {
        static int CountNumber(int number, int[] arr)
        {
            int counter = 0;

            for (int i = 0; i < arr.Length; i++) if (number == arr[i]) counter++;

            return counter;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the array length: ");
            int length = int.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter the number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} was found {1} times.", number, CountNumber(number, arr));
        }
    }
}
/* 4. Напишете метод, който намира колко пъти дадено число се среща
в даден масив. Напишете програма, която проверява дали този метод
работи правилно.*/
