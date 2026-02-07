using System;
using System.Collections.Generic;
using System.Text;

namespace Session_3_2
{
    internal class CurrentAccount : BankAccount
    {
        public decimal OverdraftLimit { get; set; }

        public CurrentAccount(string fullName, string nationalID, string phoneNumber, string address, decimal balance, decimal overdraftLimit)
            : base(fullName, nationalID, phoneNumber, address, balance)
        {
            OverdraftLimit = overdraftLimit;
        }
        public override void ShowAccountDetails()
        {
            base.ShowAccountDetails();
            Console.WriteLine($"OverdraftLimit : {OverdraftLimit}%");

        }
        public override decimal CalculateInterest()
        {
            return 0;
        }
    }
}
