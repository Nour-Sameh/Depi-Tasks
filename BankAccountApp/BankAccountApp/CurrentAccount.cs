using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountApp
{
    public class CurrentAccount : BankAccount
    {
        public decimal OverdraftLimit { get; set; }
        public override decimal Balance
        {
            get => _balance;
            set
            {
                if (value < -OverdraftLimit)
                    throw new InvalidOperationException("Exceeded overdraft limit");
                _balance = value; 
            }
        }

        public CurrentAccount(string fullName, string nationalID, string phoneNumber,
                            string address, decimal balance, decimal overdraftLimit)
            : base(fullName + " Current Account", nationalID, phoneNumber, address, balance)
        {
            if (overdraftLimit < 0)
                throw new ArgumentException("Overdraft limit cannot be negative");
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
