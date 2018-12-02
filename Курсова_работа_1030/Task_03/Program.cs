using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[31];
            int[] B = new int[31];
            int[] C = new int[31];
            int[] maxdayA = new int[31];
            int[] maxdayB = new int[31];
            int[] maxdayC = new int[31];
            int i = 0;
            int a = 0;
            int b = 0;
            int c = 0;
            int maxA = 0;
            int maxB = 0;
            int maxC = 0;

            while (i <= 31)
            {
                // Създаваме while, така че процесът да не може да се повтаря повече от 31 пъти (дните в месеца).

                Console.Write("Enter a day of the month? (y/n): ");
                string response = Console.ReadLine();

                // Задаваме въпрос дали иска да въведе нов ден на месеца 

                if (response == "y")
                {
                    Console.Write("Enter the date of the month: ");
                    sbyte dayofmonth = sbyte.Parse(Console.ReadLine());
                    Console.Write("Enter the rain for station A (м2): ");
                    A[dayofmonth] = byte.Parse(Console.ReadLine());
                    Console.Write("Enter the rain for station B (м2): ");
                    B[dayofmonth] = byte.Parse(Console.ReadLine());
                    Console.Write("Enter the rain for station C (м2): ");
                    C[dayofmonth] = byte.Parse(Console.ReadLine());

                    // До тук събираме кубичните метри валежи за всяка една от трите станции

                    if (A[dayofmonth] != 0)
                    {
                        if (maxA < A[dayofmonth])
                        {
                            maxA = A[dayofmonth];
                            //Тук запаметяваме максималната стойност валежи за станция А
                        }
                        if (A[dayofmonth] == maxA)
                        {
                            maxdayA[a] = dayofmonth;
                            a++;
                            //Ако стойността, която сме въвели е равна на максималната стойност запаметяваме деня
                        }
                    }

                    if (B[dayofmonth] != 0)
                    {
                        if (maxB < B[dayofmonth])
                        {
                            maxB = B[dayofmonth];
                        }
                        if (B[dayofmonth] == maxB)
                        {
                            maxdayB[b] = dayofmonth;
                            b++;
                        }
                    }
                    if (C[dayofmonth] != 0)
                    {
                        if (maxC < C[dayofmonth])
                        {
                            maxC = C[dayofmonth];
                        }
                        if (C[dayofmonth] == maxC)
                        {
                            maxdayC[c] = dayofmonth;
                            c++;
                        }
                    }
                    i++;
                }

                Console.Write("See the max amount of rain? (y/n): ");
                string maxresponse = Console.ReadLine();

                //Питаме дали иска да види максилните валежи за всяка станция

                if (maxresponse == "y")
                {
                    Console.WriteLine("The max amount of rain in station A this mounth is: " + maxA + " m2");
                    Console.WriteLine("The max amount of rain in station B this mounth is: " + maxB + " m2");
                    Console.WriteLine("The max amount of rain in station C this mounth is: " + maxC + " m2");
                    //Показваме максималните валежи, ако отговорът е у
                }

                Console.Write("See the days with the max amount of rain in the stations? (y/n): ");
                string daymaxresponse = Console.ReadLine();

                // Питаме дали иска да види дните, през които е имало максималния брой валежи

                if (daymaxresponse == "y")
                {
                    Console.WriteLine("The days that it rained with the max amount in station A: \n" + (string.Join(", ", maxdayA)));
                    Console.WriteLine("The days that it rained with the max amount in station B: \n" + (string.Join(", ", maxdayB)));
                    Console.WriteLine("The days that it rained with the max amount in station C: \n" + (string.Join(", ", maxdayC)));
                    // Показваме дните, през които е имало максималния брой валежи, ако отговорът е у
                }

                if (response == "n")
                {
                    System.Environment.Exit(1);
                }
            }
        }
    }
}
/* 3. 403. Съставете програма за манипулиране на месечни данни от хидрологични станции. За целта направете два метода: 
 * а)зреални а въвеждане валежите за всеки ден (в литри на кватратен метър) в едномерен масив от до 31 неотрицателни числа
 * б)за изчисляване на максималното дневно количество валежи в месеца. В главния метод въведете цяло число n=<31(брой дни в месеца)
 * и три едномерни масива A[n], B[n] и C[n], моделиращи валежите в три станции за дадения месец.
 * За всяка станция изчислете и отпечатайте стойността wна максималното количество валежи в месеца за дните през които е валяло. 
 * За всяка станция намерете и отпечатайте номерата на дните, в които количеството на валежите е 
 * равно на максималното дневно количество валежи в месеца за тази станция*/
