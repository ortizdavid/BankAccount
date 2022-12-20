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
            WriteLine("----------------------------------------------------------------");
            WriteLine("Number\t\tOrigin\t\tDestiny\t\tAmount\t\tType\t\tDate".ToUpper());
            WriteLine("----------------------------------------------------------------");
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
                        Destiny = Number,
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
                ReadKey();
            } 
        }

        public void Transfer(IAccount account1, IAccount account2)
        {
            throw new NotImplementedException();
        }

        public void WithDraw(double ammount)
        {
            throw new NotImplementedException();
        }
    }
}
