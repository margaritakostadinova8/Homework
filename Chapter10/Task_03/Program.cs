using System;

namespace Task_03
{
    class Program
    {
        static void Combos(int[] arr, int index, int start, int end)
        {
            if (index >= arr.Length)
            {
                Console.Write("(");
                for (int i = 0; i < arr.Length; i++)
                    if (i < arr.Length - 1) Console.Write("{0} ", arr[i]);
                    else Console.Write(arr[i]);
                Console.Write("), ");
            }
            else
                for (int i = start; i <= end; i++)
                {
                    arr[index] = i;
                    Combos(arr, index + 1, i, end);
                }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter the K: ");
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[k];
            Combos(arr, 0, 1, n);
        }
    }
}
/* 3. Напишете рекурсивна програма, която генерира всички вариации с
повторение на n елемента от k-ти клас.*/
