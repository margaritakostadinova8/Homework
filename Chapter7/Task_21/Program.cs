using System;

namespace Task_21
{
    class Program
    {
        public static int[] findSolution(int[] a, bool[] filter, int index, int s, int size)
        {
            if (index < a.Length)
            {
                filter[index] = true;
                int[] x = findSolution(a, filter, index + 1, s, size);

                if (x.Length > 0) return x;
                else
                {
                    filter[index] = false;
                    return findSolution(a, filter, index + 1, s, size);
                }
            }
            else
            {
                int sum = 0, count = 0;

                for (int i = 0; i < a.Length; i++)
                {
                    if (filter[i])
                    {
                        sum += a[i];
                        count++;
                    }
                }

                int[] solution = new int[0];

                if (sum == s && count == size)
                {
                    solution = new int[count];
                    count = 0;

                    for (int i = 0; i < a.Length; i++) if (filter[i]) solution[count++] = a[i];
                }
                return solution;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the N = ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter the K = ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("The sum of elements, s = ");
            int s = int.Parse(Console.ReadLine());

            int[] solution = findSolution(arr, new bool[arr.Length], 0, s, size);

            Console.WriteLine("Your solution is:");
            for (int i = 0; i < solution.Length; i++) Console.Write(solution[i] + "; ");
            Console.ReadLine();
        }
    }
}

/* 21. . Напишете програма, която по дадени N, K и S намира К на брой елементи
измежду N-те числа, чиято сума е точно S или показва, че това е
невъзможно.*/
