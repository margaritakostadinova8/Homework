using System;

namespace Task_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int tmpSeq = 1, seq = 1;
            string element = "e";

            Console.Write("Enter the N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter the M: ");
            int m = int.Parse(Console.ReadLine());

            string[,] arr = new string[n, m];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    Console.Write("Arr [{0}][{1}] = ", i, j);
                    arr[i, j] = Console.ReadLine();
                }


            for (int rows = 0; rows < arr.GetLength(0); rows++)
            {
                for (int cols = 0; cols < arr.GetLength(1) - 1; cols++)
                {
                    if (arr[rows, cols] == arr[rows, cols + 1]) tmpSeq++;
                    else tmpSeq = 1;

                    if (seq < tmpSeq)
                    {
                        seq = tmpSeq;
                        element = arr[rows, cols];
                    }
                }
                tmpSeq = 1;
            }

            for (int cols = 0; cols < arr.GetLength(1); cols++)
            {
                for (int rows = 0; rows < arr.GetLength(0) - 1; rows++)
                {
                    if (arr[rows, cols] == arr[rows + 1, cols]) tmpSeq++;
                    else tmpSeq = 1;

                    if (seq < tmpSeq)
                    {
                        seq = tmpSeq;
                        element = arr[rows, cols];
                    }
                }
                tmpSeq = 1;
            }

            for (int i = 0; i < arr.GetLength(0) - 1; i++)
                for (int j = 0; j < arr.GetLength(1) - 1; j++)
                {
                    for (int rows = i, cols = j; rows < arr.GetLength(0) - 1 && cols < arr.GetLength(1) - 1; rows++, cols++)
                    {
                        if (arr[rows, cols] == arr[rows + 1, cols + 1]) tmpSeq++;
                        else tmpSeq = 1;

                        if (seq < tmpSeq)
                        {
                            seq = tmpSeq;
                            element = arr[rows, cols];
                        }
                    }
                    tmpSeq = 1;
                }

            for (int i = 0; i < arr.GetLength(0) - 1; i++)
                for (int j = 1; j < arr.GetLength(1); j++)
                {
                    for (int rows = i, cols = j; rows < arr.GetLength(0) - 1 && cols > 0; rows++, cols--)
                    {
                        if (arr[rows, cols] == arr[rows + 1, cols - 1]) tmpSeq++;
                        else tmpSeq = 1;

                        if (seq < tmpSeq)
                        {
                            seq = tmpSeq;
                            element = arr[rows, cols];
                        }
                    }
                    tmpSeq = 1;
                }

            for (int i = 0; i < seq; i++) Console.Write("{0}, ", element);
        }
    }
}
/* 14. Да се напише програма, която намира най-дългата последователност
от еднакви string елементи в матрица. Последователност в матрица
дефинираме като елементите са съседни и са на същия ред,колона или
диагонал*/
