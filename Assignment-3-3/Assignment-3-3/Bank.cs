using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3_3
{
    internal class Bank
    {
        public string Name { get; set; }
        public string BranchCode { get; set; }

        public List<Customer> customers = new List<Customer>();

        public Bank(string name, string code)
        {
            Name = name;
            BranchCode = code;
        }
        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }
        public void RemoveCustomer(Customer customer)
        {
            foreach (var a in customer.Accounts)
            {
                if (a.Balance != 0)
                {
                    Console.WriteLine("Cannot remove customer with active accounts having balance");
                    return;
                }
            }
            customers.Remove(customer);
        }
        public Customer SearchCustomer(string value)
        {
            foreach (var customer in customers)
            {
                if (customer.NationalID == value || customer.FullName.Contains(value))
                    return customer;
            }
            return null;
        }

        public void ShowBankReport()
        {
            Console.WriteLine($"Bank Name: {Name}, Branch Code: {BranchCode}");
            Console.WriteLine("Customers:");
            foreach (var customer in customers)
            {
                Console.WriteLine($"Customer ID: {customer.CustomerID}, Name: {customer.FullName}, National ID: {customer.NationalID}, Date of Birth: {customer.DateOfBirth.ToShortDateString()}");
                Console.WriteLine("Accounts:");
                foreach (var account in customer.Accounts)
                {
                    Console.WriteLine($"Account Number: {account.AccountNumber}, Balance: {account.Balance}, Date Opened: {account.DateOpen.ToShortDateString()}");
                }
                Console.WriteLine();
            }
        }
    }
}
