using System;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] value = new int[20];

            for (int i = 0; i < value.Length; i++)
            {
                value[i] = i * 5;
                Console.WriteLine(value[i]);
            }
        }
    }
}

/* 1. Да се напише програма, която създава масив с 20 елемента от
целочислен тип и инициализира всеки от елементите със стойност,
равна на индекса на елемента умножен по 5. Елементите на масива да
се изведат на конзолата.*/
