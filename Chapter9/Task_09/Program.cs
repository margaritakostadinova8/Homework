using System;

namespace Task_09
{
    class Program
    {
        public static int GetMax(int[] array, int start, int end)
        {
            int maxNum = array[start];

            for (int i = start + 1; i < end; i++)
            {
                if (array[i] > maxNum) maxNum = array[i];
            }

            return maxNum;
        }

        public static void Main(string[] args)
        {
            Console.Write("Enter the array length: ");
            int length = int.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nEnter the start index: ");
            int startIndex = int.Parse(Console.ReadLine());

            Console.Write("Enter the end index: ");
            int endIndex = int.Parse(Console.ReadLine());

            Console.WriteLine("Biggest number in interval {0}-{1} is {2}.", startIndex, endIndex, GetMax(arr, startIndex, endIndex));
        }
    }
}
/* 9. Напишете метод, който намира най-големия елемент в част от
масив. Използвайте метода, за да сортирате низходящо даден
масив.*/
