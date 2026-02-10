using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3_3
{
    internal class SavingAccount: BankAccount
    {
        public decimal InterestRate { get; set; }
        public SavingAccount(decimal Balance, decimal interestRate)
            : base(Balance)
        {
            InterestRate = interestRate;
        }
        public override decimal CalculateInterest()
        {
            return Balance * InterestRate / 100;
        }
        public decimal CalculateMonthlyInterest()
        {
            return Balance * (InterestRate / 100) / 12;
        }

    }
}
