using System;

namespace Task_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            Console.WriteLine("All the numbers:");
            Console.WriteLine(num);
            int incremnt = 0;
            for (int i = 1; i < 25; i++) {
                num = num + 2;
                Console.WriteLine(num);
           
                incremnt = incremnt + num;
               /* С for създаваме редицата числа, които ще сумираме и отдолу ги събирамe. Накрая показваме всичките числа,
                които ще събираме и крайната сума на тези числа */
            }
            Console.WriteLine("The sum of all the numbers is: " + incremnt);
        }
    }
}
/* 5. 213. Да се изчисли:
а) 1+3+5+7+......+47+49*/
 