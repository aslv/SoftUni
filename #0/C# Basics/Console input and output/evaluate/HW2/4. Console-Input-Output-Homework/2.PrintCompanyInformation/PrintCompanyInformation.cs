using System;

class PrintCompanyInformation
{
    static void Main()
    {
        string companyName = Console.ReadLine();
        string companyAddress = Console.ReadLine();
        string companyNumber = Console.ReadLine();
        string companyFax = Console.ReadLine();
        string companySite = Console.ReadLine();
        string companyManager = Console.ReadLine();
        string managerName = Console.ReadLine();
        string managerLastName = Console.ReadLine();
        int managerAge = int.Parse(Console.ReadLine());
        string managerNumber = Console.ReadLine();
        Console.WriteLine("Company Name: {0}", companyName);
        Console.WriteLine("Company Address: {0}", companyAddress);
        Console.WriteLine("Company Number: {0}", companyNumber);
        Console.WriteLine("Company Fax: {0}", companyFax);
        Console.WriteLine("Company Website: {0}", companySite);
        Console.WriteLine("Company Manager: {0}", companyManager);
        Console.WriteLine("Manager : {0} {1}", managerName, managerLastName);
        Console.WriteLine("Manager Number: {0}", managerNumber);
        Console.WriteLine("Manager Age: {0}", managerAge);
    }
}
