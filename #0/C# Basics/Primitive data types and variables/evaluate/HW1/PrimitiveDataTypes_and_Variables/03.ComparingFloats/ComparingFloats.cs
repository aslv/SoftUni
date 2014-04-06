using System;

namespace _03.ComparingFloats
{
    class ComparingFloats
    {
        static void Main()
        {
            //This program should be compare two numbers and output result - equal or not equal
            //I input correction for border case, because difference for floating point numbers are not exact 
            decimal eps = 0.000001m;                        //Define variable for accuracy
            string Var1;                                    //Variable1 for accept input
            string Var2;                                    //Variable2 for accept input
            decimal enterVar1;                              //Variable1 for convertion string to float
            decimal enterVar2;                              //Variable2 for convertion string to float
            decimal precision1;                             //Variable1 for accept difference
            decimal precision2;                             //Variable2 for accept difference
            Console.WriteLine("This program shows which numbers are equal and which are NOT.");
            Console.WriteLine(">=============================================================<");
            Console.Write("Give me a f-point number for var1:");
            Var1 = Console.ReadLine();                       //Read first user input number
            enterVar1 = decimal.Parse(Var1);                //Convertion string to float for Var1 to enterVar1
            Console.Write("Give me a f-point number for var2:");
            Var2 = Console.ReadLine();                      //Read second user input number
            enterVar2 = decimal.Parse(Var2);                 //Convertion string to float for Var2 to enterVar2
            precision1 = Math.Abs(enterVar1 - enterVar2);   //Get difference for first case
            precision2 = enterVar2 - enterVar1;             //Get difference for second case
            //Logical operator for get tru value and otput message - equal for first case, equal for second case or NOT equal
            if(precision1<eps)
            {
                Console.WriteLine("This numbers are equal.\n {0} == {1}", enterVar1,enterVar2);
            }
            else
            {
                Console.WriteLine("This numbers are NOT equal!!!\n {0} don't equal for {1}", enterVar1, enterVar2);
            }
        }     
    }
}
