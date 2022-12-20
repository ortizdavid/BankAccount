using BankAccount.Customers;
using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Accounts
{
    public class SavingsAccount : IAccount
    {
        public int Number { get; set; }
        public double Balance { get; set; }
        public ICustomer? Customer { get; set; }
        public AccountStatus Status { get; set; }
        public List<Transaction> Transactions { get; set; }

        public SavingsAccount()
        {
            this.Transactions= new List<Transaction>();  
        }

        public void ConsultTransactions()
        {
            WriteLine("Number\t\tOrigin\t\tDestiny\t\tAmount\t\tType\t\tDate".ToUpper());
            foreach (Transaction transaction in Transactions) 
            { 
                WriteLine(transaction);
            }
        }

        public void Deposit(double amount)
        {
            try
            {
                if (amount <= 0)
                {
                    throw new Exception("Amount Must be Greather than 0");
                }
                else
                {
                    Balance  = Balance + amount;
                    var transaction = new Transaction
                    {
                        Destination = Number,
                        Origin = Number,
                        Amount = amount,
                        TransactionDate = DateTime.Now,
                        TransactionType = "Deposit",
                        Status = TransactionStatus.Succeeded
                    };
                    Transactions.Add(transaction);
                }
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            } 
        }

        public void Transfer(IAccount origin, IAccount destination, double amount)
        {
            origin.Deposit(amount);
            destination.Deposit(amount);
            var transaction = new Transaction
            {
                Origin = origin.Number,
                Destination = destination.Number,
                Amount = amount,
                TransactionDate = DateTime.Now,
                TransactionType = "Transfer",
                Status = TransactionStatus.Succeeded
            };
            Transactions.Add(transaction);
        }

        public void Withdraw(double amount)
        {
            try
            {
                if (amount <= 0)
                {
                    throw new Exception("Amount must be  greather than 0");
                }
                else if (amount > 0 && amount < Balance)
                {
                    throw new Exception("Amount must be lower than Balance");
                }
                else
                {
                    Balance = Balance - amount;
                    var transaction = new Transaction
                    {
                        Destination = Number,
                        Origin = Number,
                        Amount = amount,
                        TransactionDate = DateTime.Now,
                        TransactionType = "WithDraw",
                        Status = TransactionStatus.Succeeded
                    };
                    Transactions.Add(transaction);
                }
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
        }
    }
}
