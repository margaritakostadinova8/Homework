using System;

namespace Task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 35;
            int p = 5;
            int i = 1;
            int intvalue1 = i << p;
            Console.WriteLine((n & intvalue1) != 0 ? "The third bit is 1" : "The third bit is 0");
        }
    }
}
/* 11. Дадено е число n и позиция p. Напишете поредица от операции, които
да отпечатат стойността на бита на позиция p от числото n (0 или 1).
Пример: n=35, p=5 -> 1. Още един пример: n=35, p=6 -> 0 */
