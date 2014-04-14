using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Please enter the company name: ");
        string company = Console.ReadLine();
        Console.Write("Please enter the company address: ");
        string address = Console.ReadLine();
        Console.Write("Please enter the company phone number: ");
        string phone = Console.ReadLine();
        Console.Write("Please enter the company fax number: ");
        string fax = Console.ReadLine();
        Console.Write("Please enter the company web site: ");
        string site = Console.ReadLine();
        Console.Write("Please enter the manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Please enter the manager second name: ");
        string managerSecondName = Console.ReadLine();
        Console.Write("Please enter the manager age: ");
        string managerAge = Console.ReadLine();
        Console.Write("Please enter the manager phone: ");
        string managerPhone = Console.ReadLine();
        Console.WriteLine("\n=======================================================");
        Console.WriteLine("Company information");
        Console.WriteLine("\nName: " + company);
        Console.WriteLine("Adress: " + address);
        Console.WriteLine("Pnone number: " + phone);
        Console.WriteLine("Fax number: " + fax);
        Console.WriteLine("www: " + site);
        Console.WriteLine("\nManager information");
        Console.WriteLine("\nFirst name: " + managerFirstName);
        Console.WriteLine("Last name: " + managerSecondName);
        Console.WriteLine("Age: " + managerAge);
        Console.WriteLine("Phone number: " + managerPhone);

    }
}

