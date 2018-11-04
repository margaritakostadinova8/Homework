using System;

namespace Task_09
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringvalue1 = "The \"use\" of quotations causes difficulties.";
            string stringvalue2 = "The " + "\u0022" + "use" + "\u0022" + " of quotations causes difficulties";
        }
    }
}
/* 9. Декларирайте две променливи от тип string и им присвоете стойност
"The "use" of quotations causes difficulties." (без първите и последни
кавички). В едната променлива използвайте quoted string, а в другата
не го използвайте. */
