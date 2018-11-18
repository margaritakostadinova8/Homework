using System;

namespace Task_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the array length: ");
            int length = int.Parse(Console.ReadLine());

            int[] arr = new int[length];
            int sames = 1, bestS = 1, bStart = 0, lastElement = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] + 1 == arr[i + 1])
                {
                    sames++;
                    if (sames > bestS)
                    {
                        bestS = sames;
                        lastElement = i + 1;
                        bStart = lastElement - bestS + 1;
                    }
                }
                else sames = 1;
            }

            for (int i = bStart; i < bestS + bStart; i++) Console.Write("{0}, ", arr[i]);
        }
    }
}
/* 5. Напишете програма, която намира максималната редица от последователни
нарастващи елементи в масив. Пример: {3, 2, 3, 4, 2, 2, 4} 
{2, 3, 4}.*/
