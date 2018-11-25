using System;

namespace Task_05
{
    class Program
    {
        static void CompareNumber(int pos, int[] arr)
        {
            if (pos == 0)
            {
                if (arr[0] < arr[1]) Console.WriteLine("{0} is smaller than it's right.", arr[0]);
                else if (arr[0] > arr[1]) Console.WriteLine("{0} is bigger than it's right.", arr[0]);
                else Console.WriteLine("{0} is equal to it's right.", arr[0]);
            }
            else if (pos == arr.Length - 1)
            {
                if (arr[arr.Length - 1] < arr[arr.Length - 2]) Console.WriteLine("{0} is smaller than it's left.", arr[pos]);
                else if (arr[arr.Length - 1] > arr[arr.Length - 2]) Console.WriteLine("{0} is bigger than it's left.", arr[pos]);
                else Console.WriteLine("{0} is equal to it's left.", arr[pos]);
            }
            else
            {
                if (arr[pos] < arr[pos - 1])
                {
                    if (arr[pos] < arr[pos + 1]) Console.WriteLine("{0} is smaller than it's neighbours.", arr[pos]);
                    else if (arr[pos] == arr[pos + 1]) Console.WriteLine("{0} is smaller than it's left and equal to it's right.", arr[pos]);
                    else Console.WriteLine("{0} is smaller than it's left and bigger than it's right.", arr[pos]);
                }
                else if (arr[pos] == arr[pos - 1])
                {
                    if (arr[pos] < arr[pos + 1]) Console.WriteLine("{0} is euqal to it's left and smaller than it's right.", arr[pos]);
                    else if (arr[pos] == arr[pos + 1]) Console.WriteLine("{0} is equal to it's neighbours.", arr[pos]);
                    else Console.WriteLine("{0} is equal to it's left and bigger than it's right.", arr[pos]);
                }
                else
                {
                    if (arr[pos] < arr[pos + 1]) Console.WriteLine("{0} is bigger than it's left and smaller than it's right.", arr[pos]);
                    else if (arr[pos] == arr[pos + 1]) Console.WriteLine("{0} is bigger than it's left and equal to it's right.", arr[pos]);
                    else Console.WriteLine("{0} is bigger than it's neighbours.", arr[pos]);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the array length: ");
            int length = int.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter a position in the array: ");
            int pos = int.Parse(Console.ReadLine());

            CompareNumber(pos, arr);
        }
    }
}
/* 5. Напишете метод, който проверява дали елемент, намиращ се на дадена
позиция от масив, е по-голям от двата му съседа. Тествайте метода
дали работи коректно.*/
