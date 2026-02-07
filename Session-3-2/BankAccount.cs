using System;
using System.Collections.Generic;
using System.Text;

namespace Session_3_2
{
    internal class BankAccount
    {
        const string BankCode = "BNK001";

        readonly DateTime CreatedDate;

        private int _accountNumber;
        private string _fullName;
        private string _nationalID;
        private string _phoneNumber;
        private string _address;
        private decimal _balance;

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
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (IsValidPhoneNumber(value))
                {
                    _phoneNumber = value;
                }
            }
        }
        public string Address
        {
            get { return _address; }
            set
            {
                _address = value;
            }
        }
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
        public BankAccount()
        {
            CreatedDate = DateTime.Now;
            _balance = 0;
            _address = "";
        }
        public BankAccount(string fullName, string nationalID, string phoneNumber, string address, decimal balance)
        {
            CreatedDate = DateTime.Now;
            FullName = fullName;
            NationalID = nationalID;
            PhoneNumber = phoneNumber;
            Address = address;
            Balance = balance;
        }
        public BankAccount(string fullName, string nationalID, string phoneNumber, string address) : this(fullName, nationalID, phoneNumber, address, 0)
        {

        }
        public virtual void ShowAccountDetails()
        {
            Console.WriteLine("********** Account Details ******************");

            Console.WriteLine($"Bank Code   : {BankCode}");
            Console.WriteLine($"Full Name   : {FullName}");
            Console.WriteLine($"National ID : {NationalID}");
            Console.WriteLine($"Phone       : {PhoneNumber}");
            Console.WriteLine($"Address     : {Address}");
            Console.WriteLine($"Balance     : {Balance}");
            Console.WriteLine($"Created At  : {CreatedDate}");
            Console.WriteLine();
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

    }
}
