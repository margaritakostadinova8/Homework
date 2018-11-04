using System;

namespace Task_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your weight:");
            int weight = int.Parse(Console.ReadLine());
            Console.WriteLine("You will weight {0}kg on the Moon.", weight * 0.17);
        }
    }
}
/* 7. Силата на гравитационното поле на Луната е приблизително 17% от
това на Земята. Напишете програма, която да изчислява тежестта на
човек на Луната, по дадената тежест на Земята.*/
