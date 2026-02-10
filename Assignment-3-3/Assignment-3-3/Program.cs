using System;
using Assignment_3_3;

namespace Assignment_3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank("National Bank", "ASU001");

            while (true)
            {
                Console.WriteLine("\n1- Add Customer");
                Console.WriteLine("2- Add Account");
                Console.WriteLine("3- Deposit");
                Console.WriteLine("4- Withdraw");
                Console.WriteLine("5- Transfer");//لسه
                Console.WriteLine("6- Bank Report");
                Console.WriteLine("0- Exit");

                Console.Write("Choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Name: ");
                        string name = Console.ReadLine();

                        Console.Write("National ID: ");
                        string nid = Console.ReadLine();

                        Console.Write("DOB (yyyy-mm-dd): ");
                        DateTime dob = DateTime.Parse(Console.ReadLine());

                        Customer customer = new Customer(name, nid, dob);
                        bank.AddCustomer(customer);

                        Console.WriteLine("Customer added ");
                        break;

                    case 2:
                        Console.Write("Customer ID: ");
                        int cid = int.Parse(Console.ReadLine());

                        Customer c = FindCustomerById(bank, cid);
                        if (c == null) break;

                        Console.Write("1- Savings  2- Current: ");
                        int t = int.Parse(Console.ReadLine());

                        Console.Write("Initial Balance: ");
                        decimal balance = decimal.Parse(Console.ReadLine());

                        if (t == 1)
                        {
                            Console.Write("Interest Rate: ");
                            decimal r = decimal.Parse(Console.ReadLine());
                            c.AddAccount(new SavingAccount(balance, r));
                        }
                        else
                        {
                            Console.Write("Overdraft Limit: ");
                            decimal o = decimal.Parse(Console.ReadLine());
                            c.AddAccount(new CurrentAccount(balance, o));
                        }

                        Console.WriteLine("Account added ");
                        break;

                    case 3:
                        BankAccount acc1 = FindAccount(bank);
                        if (acc1 == null) break;

                        Console.Write("Amount: ");
                        decimal d = decimal.Parse(Console.ReadLine());

                        Console.WriteLine(acc1.Deposit(d));
                        break;

                    case 4:
                        BankAccount acc2 = FindAccount(bank);
                        if (acc2 == null) break;

                        Console.Write("Amount: ");
                        decimal w = decimal.Parse(Console.ReadLine());

                        Console.WriteLine(acc2.Withdraw(w));
                        break;

                    case 5:
                        

                    case 6:
                        bank.ShowBankReport();
                        break;

                    case 0:
                        return;
                }
            }
        }


        static Customer FindCustomerById(Bank bank, int id)
        {
            foreach (var c in bank.customers)
            {
                if (c.CustomerID == id)
                    return c;
            }

            Console.WriteLine("Customer not found ❌");
            return null;
        }

        static BankAccount FindAccount(Bank bank)
        {
            Console.Write("Account Number (Guid): ");
            Guid accNo = Guid.Parse(Console.ReadLine());

            foreach (var c in bank.customers)
            {
                foreach (var acc in c.Accounts)
                {
                    if (acc.AccountNumber == accNo)
                        return acc;
                }
            }

            Console.WriteLine("Account not found");
            return null;
        }
    }
}
