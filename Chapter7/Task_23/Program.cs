using System;

namespace Task_23
{
    class Program
    {
        public static int n;

        static void Main(string[] args)
        {
            Console.Write("Enter the N: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Enter the K: ");
            int k = int.Parse(Console.ReadLine());

            int[] arr = new int[k];

            recSolution(arr, 0);
        }

        static void recSolution(int[] array, int index)
        {
            if (index != array.Length)
                for (int i = 1; i <= n; i++)
                {
                    array[index] = i;
                    recSolution(array, index + 1);
                }
            else
            {
                for (int i = 0; i < array.Length; i++) Console.Write(array[i] + " ");
                Console.WriteLine();
            }
        }
    }
}

/* 23. Напишете програма, която прочита цяло число N от конзолата и
отпечатва всички пермутации на числата [1…N].
Пример: N = 3  {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3,
2, 1}*/
