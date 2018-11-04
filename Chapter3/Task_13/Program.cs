using System;

namespace Task_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 35;
            int p = 2;
            int v = 1;
            n = (v == 0) ? n = n & (~(1 << p)) : n = n | (1 << p);
            Console.WriteLine(n);
        }
    }
}
/* 13. Дадено е число n, стойност v (v = 0 или 1) и позиция p. Напишете
поредица от операции, които да променят стойността на n, така че
битът на позиция p да има стойност v. Пример n=35, p=5, v=0 -> n=3.
Още един пример: n=35, p=2, v=1 -> n=39.*/
