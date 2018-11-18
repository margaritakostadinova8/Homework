using System;

namespace Task_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter K (K must be bigger than N): ");
            int k = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr, (a, b) => b.CompareTo(a));

            for (int i = 0; i < k; i++) sum += arr[i];

            Console.WriteLine("\n The Biggest sum is {0}", sum);
        }
    }
}
/* 7. Да се напише програма, която чете от конзолата две цели числа N и K
(K<N), и масив от N елемента. Да се намерят тези K поредни елемента,
които имат максимална сума.*/
