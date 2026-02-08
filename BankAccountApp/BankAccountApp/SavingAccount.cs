using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountApp
{
    public class SavingAccount: BankAccount
    {
        public decimal InterestRate { get; set; }
        public SavingAccount(string fullName, string nationalID, string phoneNumber, string address, decimal initialBalance, decimal interestRate)
            : base(fullName + " Saving Account", nationalID, phoneNumber, address, initialBalance)
        {
            InterestRate = interestRate;
        }
        public override decimal CalculateInterest()
        {
            return Balance * InterestRate / 100;
        }
    }

}
