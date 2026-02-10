using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3_3
{
    internal class CurrentAccount: BankAccount
    {
        public decimal OverdraftLimit { get; set; }

        public CurrentAccount(decimal balance, decimal overdraftLimit): base(balance)
        {
            OverdraftLimit = overdraftLimit;
        }

        public override string Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                return "Withdrawal amount must be greater than zero";
            }

            decimal availableAmount = Balance + OverdraftLimit;

            if (amount > availableAmount)
            {
                return $"Insufficient funds. Available (including overdraft): {availableAmount}";
            }

            Balance -= amount;
            return $"Withdrew {amount}. New balance: {Balance}";
        }

        public override decimal CalculateInterest()
        {
            return 0;
        }
    }
}
