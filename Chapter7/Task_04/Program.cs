using System;

namespace Task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1, tCount = 1, number = 0;

            Console.Write("Enter the array length: ");
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1]) tCount++;
                else tCount = 1;

                if (tCount > count)
                {
                    count = tCount;
                    number = arr[i];
                }
            }

            for (int i = 0; i < count; i++) Console.Write("{0}, ", number);
        }
    }
}
/* 4. Напишете програма, която намира максимална редица от последователни
еднакви елементи в масив. Пример: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}
 {2, 2, 2}. */
