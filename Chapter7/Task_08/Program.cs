using System;

namespace Task_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, iMin, tmp;

            Console.Write("Enter the array length: ");
            int length = int.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (i = 0; i < length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (j = 0; j < length - 1; j++)
            {
                iMin = j;

                for (i = j + 1; i < length; i++) if (arr[i] < arr[iMin]) iMin = i;

                if (iMin != j)
                {
                    tmp = arr[j];
                    arr[j] = arr[iMin];
                    arr[iMin] = tmp;
                }
            }

            for (i = 0; i < length; i++) Console.Write("{0} ", arr[i]);
        }
    }
}

/* 8. Сортиране на масив означава да подредим елементите му в нарастващ
(намаляващ) ред. Напишете програма, която сортира масив. Да се
използва алгоритъма "Selection sort". */
