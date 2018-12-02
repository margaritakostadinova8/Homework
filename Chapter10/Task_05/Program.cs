using System;

namespace Task_05
{
    class Program
    {
        static string[] strings, str;
        static int length;

        static void cycle(int iter, int index, int k)
        {
            if (iter == k)
            {
                for (int i = 0; i < length; i++)
                    Console.WriteLine("({0})", str[i]);
                return;
            }

            for (int i = index; i < strings.Length; i++)
            {
                str[iter] = strings[i];
                cycle(iter + 1, i + 1, k);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the words length: ");
            length = int.Parse(Console.ReadLine());

            strings = new string[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter the {0} word: ", i + 1);
                strings[i] = Console.ReadLine();
            }

            for (int i = 0; i <= length; i++)
            {
                str = new string[length];
                cycle(0, 0, i);
            }
        }
    }
}
/* 5. Напишете рекурсивна програма, която отпечатва всички подмножества
на дадено множество от думи.*/
