﻿using System;

namespace Task_07
{
    class Program
    {
        static void FindCombinations(int[] arr, int index)
        {
            if (index == arr.Length)
            {
                Console.Write("{");
                for (int i = 0; i < arr.Length; i++)
                    if (i < arr.Length - 1) Console.Write("{0} ", arr[i]);
                    else Console.Write(arr[i]);
                Console.Write("}, ");
            }
            else
            {
                for (int i = index; i < arr.Length; i++)
                {
                    int temp = arr[i];
                    arr[i] = arr[index];
                    arr[index] = temp;
                    FindCombinations(arr, index + 1);
                    temp = arr[i];
                    arr[i] = arr[index];
                    arr[index] = temp;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the N: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++) arr[i] = i + 1;
            FindCombinations(arr, 0);
        }
    }
}
/* 7. Напишете рекурсивна програма, която генерира и отпечатва пермутациите
на числата 1, 2, …, n, за дадено цяло число n.*/
