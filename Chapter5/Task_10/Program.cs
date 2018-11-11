using System;

namespace Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            byte points;
            Console.Write("Enter points between 1 and 9: ");
            points = Convert.ToByte(Console.ReadLine());
            if (points >= 1 && points <= 3)
                Console.WriteLine("Points multiplied by 10: {0}", points * 10);
            else if (points >= 4 && points <= 6)
                Console.WriteLine("Points multiplied by 100: {0}", points * 100);
            else if (points >= 7 && points <= 9)
                Console.WriteLine("Points multiplied by 1000: {0}", points * 1000);
            else
                Console.WriteLine("Wrong Input!");
            Console.ReadLine();
        }
    }
}
/* 10. Напишете програма, която прилага бонус точки към дадени точки в
интервала [1..9] чрез прилагане на следните правила:
- Ако точките са между 1 и 3, програмата ги умножава по 10.
- Ако точките са между 4 и 6, ги умножава по 100.
- Ако точките са между 7 и 9, ги умножава по 1000.
- Ако точките са 0 или повече от 9, се отпечатва съобщение за
грешка.*/
