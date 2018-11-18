using System;

namespace Task_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0, tIndex, tCounter;

            Console.Write("Enter the array length: ");
            int length = int.Parse(Console.ReadLine());

            int[] arr = new int[length];
            int[] result = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < length; i++)
            {
                int[] tResult = new int[length];
                tIndex = tCounter = 1;
                tResult[0] = arr[i];

                for (int j = i + 1; j < length; j++)
                {
                    if (arr[j] > tResult[tIndex - 1])
                    {
                        tResult[tIndex] = arr[j];
                        tIndex++;
                        tCounter++;
                    }
                    else if (tIndex > 1 && arr[j] > tResult[tIndex - 2] && arr[j] < tResult[tIndex - 1]) tResult[tIndex - 1] = arr[j];
                }

                if (counter < tCounter)
                {
                    counter = tCounter;
                    result = tResult;
                }
            }

            for (int i = 0; i < counter; i++) Console.Write("{0},", result[i]);
        }
    }
}
/* 6. Напишете програма, която намира максималната подредица от нарастващи
елементи в масив arr[n]. Елементите може и да не са последователни.
Ако има няколко такива подредици, намерете най-лявата от
тях. Пример: {9, 6, 2, 7, 4, 7, 6, 5, 8, 4} -> {2, 4, 7, 8}.*/
