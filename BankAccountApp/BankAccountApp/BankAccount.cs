using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountApp
{
    public class BankAccount
    {
        const string BankCode = "BNK001";

        readonly DateTime CreatedDate;

        private Guid _accountNumber;
        private string _fullName;
        private string _nationalID;
        private string _phoneNumber;
        private string _address;
        protected decimal _balance;

        public string FullName
        {
            get { return _fullName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Full name cannot be empty");

                _fullName = value;
            }
        }
        public Guid AccountNumber
        {
            get { return _accountNumber; }
        }

        public string NationalID
        {
            get { return _nationalID; }
            set
            {
                if (!IsValidNationalID(value))
                    throw new ArgumentException("National ID is required and must be 14 digits");

                _nationalID = value;
            }
        }
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (!IsValidPhoneNumber(value))
                    throw new ArgumentException("Phone number is required must be 11 digits and start with 01");

                _phoneNumber = value;
            }
        }
        public string Address
        {
            get { return _address; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Address cannot be empty");

                _address = value;
            }
        }
        public virtual decimal Balance
        {
            get { return _balance; }
             set  // علشان اعم override في current account
            {
                if (value < 0)
                    throw new InvalidOperationException("Balance cannot be negative");

                _balance = value;
            }
        }
        
        public BankAccount(string fullName, string nationalID, string phoneNumber, string address, decimal balance)
        {
            CreatedDate = DateTime.Now;
            _accountNumber = Guid.NewGuid();
            FullName = fullName;
            NationalID = nationalID;
            PhoneNumber = phoneNumber;
            Address = address;
            Balance = balance;
        }
       

        public bool IsValidNationalID(string ID)
        {
            return ID.Length == 14;
        }

        public bool IsValidPhoneNumber(string phone)
        {
            return phone.Length == 11 && phone.StartsWith("01");
        }
        public virtual decimal CalculateInterest()
        {
            return 0;
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
    }
}
