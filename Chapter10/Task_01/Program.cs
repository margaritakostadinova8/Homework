using System;

namespace Task_01
{
    class Program
    {
        static void Loops(int[] arr, int index)
        {
            if (index >= arr.Length)
            {
                foreach (int element in arr) Console.Write("{0} ", element);
                Console.WriteLine();
            }
            else
                for (int i = 1; i <= arr.Length; i++)
                {
                    arr[index] = i;
                    Loops(arr, index + 1);
                }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the N: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Loops(arr, 0);
        }
    }
}
/* 1. Напишете програма, която симулира изпълнението на n вложени
цикъла от 1 до n. Пример: */

