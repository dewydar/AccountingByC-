using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Account cust1 = new Account("17565761", "Mostafa", 1000000);
            Account cust2 = new Account("11255641", "Ahmed");
            Console.WriteLine("Balance Mostafa Befour Transfer : {0}", cust1.GetBalance());
            Console.WriteLine("Balance Ahmed Befour Transfer : {0}", cust2.GetBalance());
            cust1.Transfer(cust2, 100000);
            Console.WriteLine(cust1);
            Console.WriteLine(cust2);
            Console.WriteLine("Balance Mostafa Befour Credit : {0}", cust1.balance);
            cust1.Credit(150000);
            Console.WriteLine("Balance Mostafa After Credit : {0}", cust1.balance);
            Console.WriteLine("Balance Ahmed Befour Debit : {0}", cust2.balance);
            cust2.Debit(50000);
            Console.WriteLine("Balance Ahmed After Debit : {0}", cust2.balance);
        }
    }
    class Account
    {
        public string id;
        public string name;
        public int balance = 0;
        public Account(string ID, string Name)
        {
            this.id = ID;
            this.name = Name;
        }
        public Account(string ID, string Name, int Balance)
        {
            this.id = ID;
            this.name = Name;
            this.balance = Balance;
        }
        public string GetId()
        {
            return "Id Is: " + this.id;
        }
        public string GetName()
        {
            return "Name Is: " + this.name;
        }
        public int GetBalance()
        {
            return this.balance;
        }
        public int Credit(int amount)
        {
            balance = balance + amount;
            return balance;
        }
        public int Debit(int amount)
        {
            if (amount <= balance)
                balance = balance - amount;
            else
                Console.WriteLine("Amount Exceeded Balance");
            return balance;
        }
        public int Transfer(Account another, int amount)
        {
            if (amount <= balance)
            {
                balance = balance - amount;
                another.balance = another.balance + amount;
                Console.WriteLine("Transfer Done");

            }
            else
                Console.WriteLine("Amount Exceeded Balance");
            return balance;
        }
        public override string ToString()
        {
            return "Account [ Id Is : " + id + " , Mr,Mrs. : " + name + ", Balance : " + balance + " ]";
        }
    }
}
