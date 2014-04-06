using System;

class EmployeeData
{
    static void Main(string[] args)
    {
        string firstName = "Ivan";
        string secondName = "Ivanov";
        sbyte age = 25;
        bool gender = true;
        ulong personalID = 8306112507;
        int employeeID = 27560000;
        string stringGender = (gender) ? "m" : "f";

        Console.WriteLine("Employee data:");
        Console.WriteLine("Name: " + firstName + " " + secondName);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Gender: " + stringGender);
        Console.WriteLine("Personal ID: " + personalID);
        Console.WriteLine("Employee ID: " + employeeID);

    }
}
