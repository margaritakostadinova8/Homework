using System;

namespace Task_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the array length: ");
            int length = int.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter the searched number: ");
            int number = int.Parse(Console.ReadLine());

            int index = Array.BinarySearch(arr, number);

            if (index >= 0) Console.Write("The number is on {0} index.", index);
            else Console.Write("The number wasn't found.");
        }
    }
}
/* 16. Да се реализира двоично търсене (binary search) в сортиран
целочислен масив.*/
