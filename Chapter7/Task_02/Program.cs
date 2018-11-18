using System;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            bool arrayeq = true;

            Console.Write("Enter the lenght of the first array: ");
            int length = int.Parse(Console.ReadLine());

            int[] arr1 = new int[length];

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write("Enter element {0}: ", i);
                arr1[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nEnter the lenght of the second array: ");

            if (length != int.Parse(Console.ReadLine())) Console.WriteLine("\nArrays have different lengths.");
            else
            {
                int[] arr2 = new int[length];

                for (int i = 0; i < arr2.Length; i++)
                {
                    Console.Write("Enter element {0}: ", i);
                    arr2[i] = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] != arr2[i])
                    {
                        Console.WriteLine("\nArrays are different.");
                        arrayeq = false;
                        break;
                    }
                }

                if (arrayeq) Console.WriteLine("\nArrays are the same.");
            }
        }
    }
}
/* 2. Да се напише програма, която чете два масива от конзолата и проверява
дали са еднакви.*/
