﻿using System;

namespace Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0, tmpCount = 1, foundNumber = 0;

            Console.Write("Enter the array length: ");
            int length = int.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr);

            for (int i = 0; i < length - 1; i++)
            {
                if (arr[i] == arr[i + 1]) tmpCount++;
                else tmpCount = 1;
                if (tmpCount > counter)
                {
                    counter = tmpCount;
                    foundNumber = arr[i];
                }
            }

            Console.WriteLine("{0} was found {1} times.", foundNumber, counter);
        }
    }
}
/* 10. Напишете програма, която намира най-често срещания елемент в
масив. Пример: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (среща се 5
пъти). */
