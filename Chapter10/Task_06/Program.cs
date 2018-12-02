﻿using System;

namespace Task_06
{
    class Program
    {
        static public void DoMerge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, left_end, num_elements, tmp_pos;

            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);

            while ((left <= left_end) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[tmp_pos++] = numbers[left++];
                else
                    temp[tmp_pos++] = numbers[mid++];
            }

            while (left <= left_end)
                temp[tmp_pos++] = numbers[left++];

            while (mid <= right)
                temp[tmp_pos++] = numbers[mid++];

            for (i = 0; i < num_elements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }

        static public void MergeSort_Recursive(int[] numbers, int left, int right)
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                MergeSort_Recursive(numbers, left, mid);
                MergeSort_Recursive(numbers, (mid + 1), right);
                DoMerge(numbers, left, (mid + 1), right);
            }
        }


        static void Main(string[] args)
        {
            Console.Write("Enter the array length: ");
            int length = int.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter the {0} element: ", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nSorted");

            MergeSort_Recursive(arr, 0, length - 1);
            for (int i = 0; i < length; i++)
                Console.WriteLine(arr[i]);
        }
    }
}
/* 6. Реализирайте алгоритъма "сортиране чрез сливане" (merge-sort). При
него началният масив се разделя на две равни по големина части,
които се сортират (рекурсивно чрез merge-sort) и след това двете
сортирани части се сливат, за да се получи целият масив в сортиран
вид.*/
