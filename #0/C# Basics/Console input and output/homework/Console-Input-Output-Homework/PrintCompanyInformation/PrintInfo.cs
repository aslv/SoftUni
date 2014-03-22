using System;

namespace PrintCompanyInformation
{
    class PrintInfo
    {
        static void Main()
        {
            Console.Write("Company name: ");
            string companyName = Console.ReadLine();
            Console.Write("Company address: ");
            string companyAddress = Console.ReadLine();
            Console.Write("Company phone number: ");
            string companyPhoneNumber = Console.ReadLine();
            Console.Write("Company fax number: ");
            string companyFaxNumber = Console.ReadLine();
            Console.Write("Company website: ");
            string companyWebSite = Console.ReadLine();
            Console.Write("Manager first name: ");
            string managerFirstName = Console.ReadLine();
            Console.Write("Manager last name: ");
            string managerLastName = Console.ReadLine();
            Console.Write("Manager age: ");
            byte managerAge = byte.Parse(Console.ReadLine());
            Console.Write("Manager phone number: ");
            string managerPhoneNumber = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Company name: {0}", companyName);
            Console.WriteLine("Company address: {0}", companyAddress);
            Console.WriteLine("Company phone number: {0}", companyPhoneNumber);
            Console.WriteLine("Company fax number: {0}", companyFaxNumber);
            Console.WriteLine("Company website: {0}", companyWebSite);
            Console.WriteLine("Manager first name: {0}", managerFirstName);
            Console.WriteLine("Manager last name: {0}", managerLastName);
            Console.WriteLine("Manager age: {0}", managerAge);
            Console.WriteLine("Manager phone number: {0}", managerPhoneNumber);
        }
    }
}
