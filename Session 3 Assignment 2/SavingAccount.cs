using System;
using System.Collections.Generic;
using System.Text;

namespace Session_3_2
{
    internal class SavingAccount : BankAccount
    {
        public decimal InterestRate { get; set; }

        public SavingAccount(string fullName, string nationalID, string phoneNumber, string address, decimal balance,decimal interestRate)
            :base(fullName, nationalID, phoneNumber, address, balance)
        {
            InterestRate = interestRate;
        }
        public override void ShowAccountDetails()
        {
            base.ShowAccountDetails();
            Console.WriteLine($"InterestRate : {InterestRate}%");

        }
        public override decimal CalculateInterest()
        {
            return Balance * InterestRate / 100; 
        }
    }
}
