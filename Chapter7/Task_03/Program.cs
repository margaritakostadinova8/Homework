using System;

namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            bool arrayeq = true;
            char[] arr1 = new char[5] { 'h', 'e', 'l', 'l', 'o' };
            char[] arr2 = new char[5] { 'w', 'o', 'r', 'l', 'd' };

            if (arr1.Length > arr2.Length) Console.WriteLine("Second array is lexicographicaly first.");
            else if (arr1.Length < arr2.Length) Console.WriteLine("First array is lexicographicaly first.");
            else
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] < arr2[i])
                    {
                        Console.WriteLine("First array is lexicographicaly first.");
                        arrayeq = false;
                        break;
                    }
                    if (arr1[i] > arr2[i])
                    {
                        Console.WriteLine("Second array is lexicographicaly first.");
                        arrayeq = false;
                        break;
                    }
                }

                if (arrayeq) Console.WriteLine("Arrays are lexicographicaly equal.");
            }
        }
    }
}
/* 3. Да се напише програма, която сравнява два масива от тип char
лексикографски (буква по буква) и проверява кой от двата е по-рано
в лексикографската подредба.*/
