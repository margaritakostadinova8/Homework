using System;

namespace Task_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //a)
            {
                Console.Write("Enter the height: ");
                int y = int.Parse(Console.ReadLine());

                Console.Write("Enter the width: ");
                int x = int.Parse(Console.ReadLine());

                int a = 0;

                for (int i = 1; i <= y; i++)
                {
                    Console.Write("{0} ", i);

                    a += i;

                    for (int j = 1; j < x; j++)
                    {
                        a += y;
                        Console.Write("{0} ", a);
                    }

                    a = 0;
                    Console.WriteLine();
                }

                /* b) 
                 Console.WriteLine("Enter the matrix size: ");
            int n = int.Parse(Console.ReadLine());

            int[,] arr = new int[n, n];
            arr[0, 0] = 1;

            for (int i = 1; i < arr.GetLength(0); i++)
                if (i % 2 == 1) arr[0, i] = arr[0, i - 1] + n * 2 - 1;
                else arr[0, i] = arr[0, i - 1] + 1;

            for (int i = 1; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    if (j % 2 == 1) arr[i, j] = arr[i - 1, j] - 1;
                    else arr[i, j] = arr[i - 1, j] + 1;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++) Console.Write("{0, 4}", arr[i, j]);
                Console.WriteLine();
            }*/

                /* c) 
                 Console.Write("Enter the arr size: ");
            int length = int.Parse(Console.ReadLine());

            int[,] arr = new int[length, length];
            arr[length - 1, 0] = 1;
            int counter = 1;
            for (int row = length - 2; row >= 0; row--)
            {
                arr[row, 0] = arr[row + 1, 0] + counter;
                int newRow = row;
                for (int diagonal = 1; diagonal <= counter; diagonal++)
                {
                    arr[newRow + 1, diagonal] = arr[newRow, diagonal - 1] + 1;
                    newRow++;
                }
                counter++;
            }

            arr[0, length - 1] = length * length;
            int diagonalLength = 2;
            int posX = 1;
            int posY = length - 1;
            int prevX = 0;
            int prevY = length - 1;

            for (int i = 1; i < counter - 1; i++)
            {
                for (int j = 1; j <= diagonalLength; j++)
                {
                    arr[posX, posY] = arr[prevX, prevY] - 1;
                    prevX = posX;
                    prevY = posY;
                    posX--;
                    posY--;
                }
                diagonalLength++;
                posX = i + 1;
                posY = length - 1;
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++) Console.Write("{0, 4}", arr[i, j]);
                Console.WriteLine();
            }*/
                /* d) 
                 Console.Write("Enter the arr size: ");
                int length = Int32.Parse(Console.ReadLine());

                int[,] arr = new int[length, length];
                int numConcentricSquares = (int)Math.Ceiling((length) / 2.0);
                int sideLen = length;
                int currNum = 0;

                for (int i = 0; i < numConcentricSquares; i++)
                {

                    for (int j = 0; j < sideLen; j++) arr[i + j, i] = ++currNum;

                    for (int j = 1; j < sideLen - 1; j++) arr[length - 1 - i, i + j] = ++currNum;

                    for (int j = sideLen - 1; j > 0; j--) arr[i + j, length - 1 - i] = ++currNum;

                    for (int j = sideLen - 1; j > 0; j--) arr[i, i + j] = ++currNum;

                    sideLen -= 2;
                }


                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++) Console.Write("{0, 4}", arr[i, j]);
                    Console.WriteLine();
                }*/
            }

        }
    }
}
/* 12. Напишете програма, която създава следните квадратни матрици и ги
извежда на конзолата във форматиран вид. Размерът на матриците се
въвежда от конзолата. */
