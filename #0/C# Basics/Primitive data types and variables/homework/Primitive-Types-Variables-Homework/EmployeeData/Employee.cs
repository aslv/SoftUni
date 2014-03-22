using System;

namespace EmployeeData
{
    class Employee
    {
        static void Main()
        {
            string firstName = "Gusin";
            string lastName = "Gospodinov";
            byte age = 100;
            char gender = 'm'; // bool also would be suitable
            long personalID = 8306112507;
            int uniqueEmployeeNumber = 27569999;
            Console.WriteLine("Names: {0} {1}", firstName, lastName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Personal ID number: {0}", personalID);
            Console.WriteLine("Unique employee number: {0}", uniqueEmployeeNumber);
        }
    }
}
