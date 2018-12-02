using System;

namespace Task_04
{
    class Program
    {
        static string[] wordsArr;

        static void Subs(int[] arr, int index, int start, int end)
        {
            if (index >= arr.Length)
            {
                Console.Write("(");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write("{0}", wordsArr[arr[i]]);
                    if (i != arr.Length - 1) Console.Write(" ");
                }
                Console.Write("), ");
            }
            else
                for (int i = start; i < end; i++)
                {
                    arr[index] = i;
                    Subs(arr, index + 1, i + 1, end);
                }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the array length: ");
            int length = int.Parse(Console.ReadLine());
            wordsArr = new string[length];
            Console.WriteLine();
            for (int i = 0; i < wordsArr.Length; i++)
            {
                Console.Write("Enter the {0} word: ", i + 1);
                wordsArr[i] = Console.ReadLine();
            }
            Console.Write("\nEnter the K: ");
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[k];
            Console.WriteLine();
            Subs(arr, 0, 0, length);
            Console.ReadLine();
        }
    }
}
/* 4. Нека е дадено множество от символни низове. Да се напише рекурсивна
програма, която генерира всички подмножества съставени от
точно k на брой символни низа, избрани измежду елементите на това
множество. */
