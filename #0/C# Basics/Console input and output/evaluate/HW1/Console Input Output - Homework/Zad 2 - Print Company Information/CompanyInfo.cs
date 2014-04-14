using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_2___Print_Company_Information
{
    class CompanyInfo
    {
        static void Main(string[] args)
        {
            Console.Write("Company name: ");                // input
            string companyName = Console.ReadLine();
            Console.Write("Address: ");
            string address = Console.ReadLine();
            Console.Write("Phone number: ");
            string phone = Console.ReadLine();
            Console.Write("Fax number: ");
            string fax = Console.ReadLine();
            Console.Write("Web site: ");
            string webSite = Console.ReadLine();
            Console.WriteLine("Manager info:");
            Console.Write("First name: ");
            string managerFirstName = Console.ReadLine();
            Console.Write("Last name: ");
            string managerLastName = Console.ReadLine();
            Console.Write("Age: ");
            byte managerAge = byte.Parse(Console.ReadLine());
            Console.Write("Manager phone number: ");
            string managerPhone = Console.ReadLine();

            Console.WriteLine('\n');

            Console.WriteLine("Company name: {0}", companyName);                // output
            Console.WriteLine("Address: {0}", address);
            Console.WriteLine("Phone number: {0}", phone);
            Console.WriteLine("Fax number: {0}", fax);
            Console.WriteLine("Web site: {0}", webSite);
            Console.WriteLine("Manager info:");
            Console.WriteLine("First name: {0}", managerFirstName);
            Console.WriteLine("Last name: {0}", managerLastName);
            Console.WriteLine("Age: {0}", managerAge);
            Console.WriteLine("Manager phone number: {0}", managerPhone);
        }
    }
}
