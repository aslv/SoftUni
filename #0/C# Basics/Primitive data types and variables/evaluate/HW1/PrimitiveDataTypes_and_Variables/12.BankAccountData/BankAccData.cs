using System;

namespace _12.BankAccountData
{
    class BankAccData
    {
        static void Main()
        {
            string firstName;
            string middleName;
            string lastName;
            decimal balance = 853187.5847M;
            string currency = "euro";
            string bankName = "BULGARIAN NATIONAL BANK";
            ulong IBAN = 901203789812;
            ulong card1 = 901203789809;
            ulong card2 = 901203789810;
            ulong card3 = 901203789811;
            Console.Write("Insert first name for holder: ");
            firstName = Console.ReadLine();
            Console.Write("Insert middle name for holder: ");
            middleName = Console.ReadLine();
            Console.Write("Insert last name for holder: ");
            lastName = Console.ReadLine();
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("Holder name:     {0} {1} {2}",firstName, middleName, lastName);
            Console.WriteLine("Balance:         {0} {1}", balance, currency);
            Console.WriteLine("Your bank name:  {0}", bankName);
            Console.WriteLine("IBAN:            {0}", IBAN);
            Console.WriteLine("You have 3 credit cards with numbers");
            Console.WriteLine("Credit card 1:   {0}",card1);
            Console.WriteLine("Credit card 1 has a limit equal to your balance!");
            Console.WriteLine("Credit card 2:   {0}",card2);
            Console.WriteLine("Credit card 2 has a limit depending on your balance for credit card 1!");
            Console.WriteLine("Credit card 3:   {0}",card3);
            Console.WriteLine("Credit card 3 has a limit depending ot your balance for credit card 1 and 2!");
            Console.WriteLine("*****************************************************************************");
        }
    }
}
