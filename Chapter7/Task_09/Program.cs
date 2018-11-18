﻿using System;

namespace Task_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, tmpSum;

            Console.Write("Enter the array length: ");
            int length = int.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < length - 1; i++)
            {
                tmpSum = arr[i];

                for (int j = i + 1; j < length; j++)
                {
                    tmpSum += arr[j];
                    if (tmpSum > sum) sum = tmpSum;
                }
            }

            Console.WriteLine("The result is {0}. ", sum);
        }
    }
}
/* 9. Напишете програма, която намира последователност от числа, чиято
сума е максимална. Пример: {2, 3, -6, -1, 2, -1, 6, 4, -8, 8} -> 11*/
