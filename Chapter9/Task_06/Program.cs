﻿using System;

namespace Task_06
{
    class Program
    {
        static int number = int.MinValue;

        static void CompareNumber(int[] arr)
        {
            for (int i = 1; i < arr.Length - 1; i++)
                if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                {
                    number = arr[i];
                    break;
                }
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

            CompareNumber(arr);

            if (number == int.MinValue) Console.WriteLine("-1");
            else Console.WriteLine("{0} is bigger than it's neighbours", number);
        }
    }
}
/* 6. Напишете метод, който връща позицията на първия елемент на
масив, който е по-голям от двата свои съседи едновременно, или -1,
ако няма такъв елемент. */
