using System;

namespace _11.EmployeeData
{
    class EmployeeData
    {
        static void Main()
        {
            string firstName = "Mariana";
            string lastName = "Aleksieva";
            byte age = 27;
            char gender = 'f';
            long idNumber = 8215332704;
            uint employeeNumb = 27568432;
            Console.WriteLine("----------Employee------------------------------------");
            Console.WriteLine("First Name:                       |  {0}", firstName);
            Console.WriteLine("Last Name:                        |  {0}", lastName);
            Console.WriteLine("Age:                              |  {0}", age);
            Console.WriteLine("Gender (male/female):             |  {0}", gender);
            Console.WriteLine("Personal ID Number (10-character) |  {0}:", idNumber);
            Console.WriteLine("Unique employee number:           |  {0}", employeeNumb);
            //Insert new Employee
            string firstNameNew;
            string lastNameNew;
            byte ageNew;
            char genderNew;
            long idNumberNew;
            uint employeeNumbNew;
            //string fLoat;
            Console.WriteLine("--------------------NewEmployee-----------------------");
            Console.Write("Insert first name for new employee: ");
            firstNameNew = Console.ReadLine();
            Console.Write("Insert last name for employee: ");
            lastNameNew = Console.ReadLine();
            //fLoat = Console.ReadLine();
            Console.Write("Insert age for employee:  ");
            ageNew = byte.Parse(Console.ReadLine());
            Console.Write("Insert gender for new employee (m/f): ");
            genderNew = char.Parse(Console.ReadLine());
            Console.Write("Insert 10 numbers for personal ID number: ");
            idNumberNew = long.Parse(Console.ReadLine());
            Console.Write("Insert 8 numbers for employee number: ");
            employeeNumbNew = uint.Parse(Console.ReadLine());
            Console.WriteLine("Generate new employee");
            Console.WriteLine("-----------------------Employee-----------------------");
            Console.WriteLine("First Name:                      |   {0}", firstNameNew);
            Console.WriteLine("Last Name:                       |   {0}", lastNameNew);
            Console.WriteLine("Age:                             |   {0}", ageNew);
            Console.WriteLine("Gender:                          |   {0}", genderNew);
            Console.WriteLine("Personal ID Number (10-character)|   {0}:", idNumberNew);
            Console.WriteLine("Unique employee number:          |   {0}", employeeNumbNew);
            //Old employee
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("First Name:                      |   {0}", firstName);
            Console.WriteLine("Last Name:                       |   {0}", lastName);
            Console.WriteLine("Age:                             |   {0}", age);
            Console.WriteLine("Gender (male/female):            |   {0}", gender);
            Console.WriteLine("Personal ID Number (10-character)|   {0}:", idNumber);
            Console.WriteLine("Unique employee number:          |   {0}", employeeNumb);

        }
    }
}
