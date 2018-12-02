using System;

namespace Task_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the array length: ");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter the {0} element: ", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter the sum: ");
            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                int first = array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    int second = array[j];

                    if ((first + second) == sum)
                        Console.WriteLine("({0}, {1}) ", first, second);
                }
            }
        }
    }
}
/* 9. Даден е масив с цели положителни числа. Напишете програма, която
проверява дали в масива съществуват едно или повече числа, чиято
сума е N. Можете ли да решите задачата без рекурсия?*/
