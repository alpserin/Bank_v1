using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_v1
{
    class Customer
    {
        public string Name;
        public string Surname;
        public int age;
        public string address;
        public string contact;
        public string customerNo;

        public void OpenAccount()
        {

        }

        public void MoneyTransfer()
        {

        }

        // more to be added...
    }

    class BankAccount
    {
        public string AccountNumber;
        public int Balance;
        public Customer Owner;
        public DateTime OpeningDate;
        public string AccountType;

        public bool DepositMoney(int amount)
        {
            Balance += amount;
            Console.WriteLine("Money deposit succesful.");
            return true;
        }
        public bool WithdrawMoney(int amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("You do not have enough funds.");
                return false;
            }
            else if (amount > 20000)
            {
                Console.WriteLine("Daily withdrawal limit.");
                return false;
            }
            else
            {
                Balance -= amount;
                Console.WriteLine("Successful withdrawal.");
                return true;
            }
        }

        public bool ShowBalance()
        {
            Console.WriteLine(Balance);
            return true;
        }

        // more to be added...


    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.Name = "Alp";
            c1.Surname = "Serin";
            c1.age = 23;
            c1.address = "Istanbul, Turkey, 34535";
            c1.contact = "+90533564182579";
            c1.customerNo = "684169537";

            BankAccount acc1 = new BankAccount();
            acc1.Owner = c1;
            acc1.AccountNumber = "97849813516846";
            acc1.AccountType = "Term Deposit";
            acc1.OpeningDate = DateTime.Now;
            acc1.Balance = 1500;

            while (true)
            {
                Console.WriteLine("Enter the operation : (enter 'help' for help).. ");
                string s = Console.ReadLine();
                if (s == "help")
                {
                    Console.WriteLine("Type 'Add' to deposit money.");
                    Console.WriteLine("Type 'Withdraw' to withdraw money.");
                    Console.WriteLine("Type 'Balance' to see your balance.");
                    Console.WriteLine("Type 'Exit' to exit.");
                }
                else if (s == "Add")
                {
                    Console.WriteLine("Enter the amount you want to deposit : ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    acc1.DepositMoney(a);
                }
                else if (s == "Withdraw")
                {
                    Console.WriteLine("Enter the amount you want to withdraw : ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    acc1.WithdrawMoney(b);
                }
                else if (s == "Balance")
                {
                    acc1.ShowBalance();
                }
                else if (s == "Exit")
                {
                    break;
                }
            }

        }
    }
}
