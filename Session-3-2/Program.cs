using System;
using System.Collections.Generic; // for list ya nour

namespace Session_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BankAccount acc1 = new BankAccount("Nour Sameh", "30504525987524", "01025688511", "Cairo", 7000);
            //BankAccount acc2 = new BankAccount("Sara Mohamed", "98765432109876", "01123456789", "Giza");

            //acc1.ShowAccountDetails();
            //acc2.ShowAccountDetails();

            BankAccount cAcc = new CurrentAccount("Nour Sameh", "30504525987524", "01025688511", "Cairo", 7000, 10);
            BankAccount sAcc = new SavingAccount("Sara Mohamed", "98765432109876", "01123456789", "Giza", 100, 50);

            List<BankAccount>accounts =new List<BankAccount>();
            accounts.Add(cAcc);
            accounts.Add(sAcc);
            foreach (var acc in accounts)
            {
                acc.ShowAccountDetails();
                Console.WriteLine($"Calculated Interest: {acc.CalculateInterest()}");
                Console.WriteLine();
            }
        }
    }
}

