using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3_3
{
    internal class Customer
    {
        public static int IDCounter = 0;
        public int CustomerID ;
        private string _fullName;
        private string _nationalID;
        public DateTime DateOfBirth { get; set; }
        public List<BankAccount> Accounts = new List<BankAccount>();

        public Customer( string fullName, string nationalID, DateTime dateOfBirth)
        {
            CustomerID = ++IDCounter;
            FullName = fullName;
            NationalID = nationalID;
            DateOfBirth = dateOfBirth;
        }

        public string FullName
        {
            get { return _fullName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _fullName = value;
                }
            }
        }
        public string NationalID
        {
            get { return _nationalID; }
            set
            {
                if (value.Length == 14)
                {
                    _nationalID = value;
                }
            }
        }
        public void AddAccount(BankAccount account)
        {
            Accounts.Add(account);
        }
        public void RemoveAccount(BankAccount account)
        {
            if (account.Balance > 0)
            {
                Console.WriteLine("Cannot remove account with balance");
                return;
            }
            Accounts.Remove(account);
        }
        public void UpdateCustomerDetails(string fullName, DateTime dateOfBirth)
        {
            FullName = fullName;
            DateOfBirth = dateOfBirth;
        }
        public void ShowCustomerBalance()
        {
            Console.WriteLine($"Customer: {FullName} (ID: {CustomerID})");
            decimal totalBalance = 0;
            foreach (var account in Accounts)
            {
                totalBalance += account.Balance;
                Console.WriteLine($"Account Number: {account.AccountNumber}, Balance: {account.Balance}");
            }
            Console.WriteLine($"Total Balance: {totalBalance}");
        }   
    }
}
