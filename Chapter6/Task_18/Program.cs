using System;

namespace Task_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int row = 0, col = 0, direction = 0;

            for (int i = 1; i <= n * n; i++)
            {
                switch (direction)
                {
                    case 0:
                        if (col > n - 1 || matrix[row, col] != 0)
                        {
                            direction = 1;
                            col--;
                            row++;
                        }
                        break;
                    case 1:
                        if (row > n - 1 || matrix[row, col] != 0)
                        {
                            direction = 2;
                            row--;
                            col--;
                        }
                        break;
                    case 2:
                        if (col < 0 || matrix[row, col] != 0)
                        {
                            direction = 3;
                            col++;
                            row--;
                        }
                        break;
                    case 3:
                        if (row < 0 || matrix[row, col] != 0)
                        {
                            direction = 0;
                            row++;
                            col++;
                        }
                        break;
                }

                matrix[row, col] = i;

                switch (direction)
                {
                    case 0: col++; break;
                    case 1: row++; break;
                    case 2: col--; break;
                    case 3: row--; break;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] < 10) Console.Write("{0}  ", matrix[i, j]);
                    else Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
/* 18. Напишете програма, която по дадено число n, извежда матрица във
формата на спирала:
 пример при n=4*/
