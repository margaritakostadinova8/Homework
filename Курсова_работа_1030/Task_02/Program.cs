using System;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cityname = new string[50];
            string[] maxcities = new string[50];
            string city;
            int i = 0;
            int a = 0;
            int maxcity = 0;

            while (i < 50)
            {

                Console.Write("Enter a new city y/n?: ");
                string response = Console.ReadLine();

                //Питаме дали да въведе нов град 

                if (response == "y")
                {
                    Console.Write("Enter the name of the city: ");
                    city = Console.ReadLine();
                    cityname[i] = city;
                    char[] array = cityname[i].ToCharArray();

                    /* Тук питаме името на града, запаметяваме в string името на града и запаметяаваме stringat в
                     * масива string и създаваме нов масив char, който има стойността на масива string  */

                    if (array.Length >= 1)
                    {
                        if (char.IsLower(array[i]))
                        {
                            Console.WriteLine("Try again with a Uppercase letter at the start!");
                        }
                        /* Ако дължината на масива array е 1 или по-голямо (не е празно), проверяваме дали първата
                        * буква от въведеното е малка буква и ако е показваме по конзола да се опита с главна */
                    }
                    if (maxcity < city.Length)
                    {
                        maxcity = city.Length;
                        /*ако максималната дължина дъжина букви е по-малка от дължината на въведения град правим 
                         * максималната дължина букви равна на дължината букви на въведения град */
                    }
                    if (city.Length == maxcity)
                    {
                        maxcities[a] = city;
                        a++;
                        // Ако въведения град има същата дължина като максималната дължина букви го запаметяваме в масив
                    }
                    i++;
                }

                Console.Write("See all the cities with the highest character count? (y/n) ");
                string maxresponse = Console.ReadLine();

                if (maxresponse == "y")
                {
                    Console.WriteLine("The cities: \n" + (string.Join(", ", maxcities)));

                    // Показваме всичките стойности в масива, където запаметяваме градовете с максимална стойност дължина 

                }

                if (response == "n")
                {
                    System.Environment.Exit(1);
                }

            }
        }
    }
}
/* 2. 372. Елементите на масивса имена на населени места, започващи с главна буква.Да се съставят методите за:
 * а) въвеждане на елементите на масива (не повече от 50) 
 * з) намиране на максималната дължина на име на населено място и извеждане на екрана на всички населени места,
 чиито имена са с тази максимална дължина*/

