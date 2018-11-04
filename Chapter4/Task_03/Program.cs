using System;

namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter company name:");
            string compName = Console.ReadLine();
            Console.Write("Enter company address:");
            string compAddr = Console.ReadLine();
            Console.Write("Enter company phone number:");
            string compPhone = Console.ReadLine();
            Console.Write("Enter company fax number:");
            string compFax = Console.ReadLine();
            Console.Write("Enter company website:");
            string compSite = Console.ReadLine();
            Console.Write("Enter company manager:");
            string compManager = Console.ReadLine();
            Console.Write("Enter manager first name:");
            string managerFName = Console.ReadLine();
            Console.Write("Enter manager last name:");
            string managerLName = Console.ReadLine();
            Console.Write("Enter manager phone:");
            string managerPhone = Console.ReadLine();

            Console.WriteLine("Firm: Name - {0}, Address - {1}, Number - {2}, Fax - {3}, Website - {4}, Manager - {5}", compName, compAddr, compPhone, compFax, compSite, compManager);
            Console.WriteLine("Manager: Name - {0} {1}, Phone - {2}", managerFName, managerLName, managerPhone);
        }
    }
}
/* 3. Дадена фирма има име, адрес, телефонен номер, факс номер, уеб сайт
и мениджър. Мениджърът има име, фамилия и телефонен номер. 
Глава 4. Вход и изход от конзолата 191
Напишете програма, която чете информацията за фирмата и нейния
мениджър и я отпечатва след това на конзолата. */
