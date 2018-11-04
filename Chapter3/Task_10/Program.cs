using System;

namespace Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 4 numbers:");
            int numbers = Convert.ToInt32(Console.ReadLine());
            int a = numbers / 1000;
            int b = (numbers / 100) % 10;
            int c = (numbers / 10) % 10;
            int d = numbers % 10;

            Console.WriteLine("Sum of all the digits = {0}", a + b + c + d);
            Console.WriteLine("The digits backwards = {3}{2}{1}{0}", a, b, c, d);
            Console.WriteLine("The last digit on 1st place = {3}{0}{1}{2}", a, b, c, d);
            Console.WriteLine("Replace 3rd and 2nd digit = {0}{2}{1}{3}", a, b, c, d);
        }
    }
}
/* 10. Напишете програма, която приема за вход четирицифрено число във
формат abcd (например числото 2011) и след това извършва следните
действия върху него:
- Пресмята сбора от цифрите на числото (за нашия пример 2+0+1+1
= 4).
- Разпечатва на конзолата цифрите в обратен ред: dcba (за нашия
пример резултатът е 1102).
- Поставя последната цифра на първо място: dabc (за нашия пример
резултатът е 1201).
- Разменя мястото на втората и третата цифра: acbd (за нашия
пример резултатът е 2101).*/
