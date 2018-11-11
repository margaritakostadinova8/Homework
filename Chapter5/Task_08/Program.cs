using System;

namespace Task_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter variable type (0 - int, 1 - double, 2 string):");
            int intVar = int.Parse(Console.ReadLine());

            switch (intVar)
            {
                case 0:
                    {
                        Console.Write("Enter int variable:");
                        intVar = int.Parse(Console.ReadLine());
                        intVar++;
                        Console.WriteLine("Int variable +1 = {0}", intVar);
                        break;
                    }
                case 1:
                    {
                        Console.Write("Enter double variable:");
                        double doubleVar = double.Parse(Console.ReadLine());
                        doubleVar++;
                        Console.WriteLine("Double variable +1 = {0}", doubleVar);
                        break;
                    }
                case 2:
                    {
                        Console.Write("Enter string variable:");
                        string stringVar = Console.ReadLine();
                        stringVar = stringVar + '*';
                        Console.WriteLine("String variable +* = {0}", stringVar);
                        break;
                    }
                default: Console.WriteLine("Wrong input"); break;
            }
        }
    }
}
/* 8. Напишете програма, която по избор на потребителя прочита от
конзолата променлива от тип int, double или string. Ако променливата
е int или double, трябва да се увеличи с 1. Ако променливата е string,
трябва да се прибави накрая символа "*". Отпечатайте получения
резултат на конзолата. Използвайте switch конструкция.*/
