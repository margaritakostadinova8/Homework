using System;

namespace Task_08
{
    class Program
    {
        static void Main(string[] args)
        {
            String stringvalue1 = "Hello";
            String stringvalue2 = "World";
            object objectvalue1 = stringvalue1 + " " + stringvalue2;
            string stringvalue3 = objectvalue1.ToString();
        }
    }
}
/* 8. Декларирайте две променливи от тип string и им присвоете стойности
"Hello" и "World". Декларирайте променлива от тип object и и присвоете
стойността на конкатенацията на двете променливи от тип string (не
изпускайте интервала по средата). Декларирайте трета променлива от
тип string и я инициализирайте със стойността на променливата от тип
object (трябва да използвате type casting). */
