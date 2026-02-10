using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3_3
{
    internal class BankAccount
    {

        public Guid AccountNumber;
        private decimal _balance;
        public DateTime DateOpen { get; set; }
        public decimal Balance
        {
            get { return _balance; }
            set
            {
                if (value >= 0)
                {
                    _balance = value;
                }
            }
        }
        public BankAccount(decimal balance)
        {
            AccountNumber = Guid.NewGuid();
            Balance = balance;
            DateOpen = DateTime.Now;
        }
        public virtual string Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                return "Deposit amount must be greater than zero";
            }
            Balance += amount;
            return $"Deposited {amount}. New balance: {Balance}";
        }
        public virtual string Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                return "Withdrawal amount must be greater than zero";
            }
            if (amount > Balance)
            {
                return "Insufficient funds for this withdrawal";
            }
            Balance -= amount;
            return $"Withdrew {amount} New balance: {Balance}";
        }

        public virtual decimal CalculateInterest()
        {
            return 0;
        }

    }
}
