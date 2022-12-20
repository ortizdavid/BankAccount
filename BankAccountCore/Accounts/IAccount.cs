using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccount.Customers;

namespace BankAccount.Accounts
{
    public interface IAccount
    {
        public string Number { get; set; }
        public double Balance { get; }
        public ICustomer Customer { get; set; }
        public AccountStatus Status { get; set; }
        public List<Transaction> Transactions { get; set; }
        public void WithDraw(double ammount);
        public void Deposit(double amount);
        public void Transfer(IAccount account1, IAccount account2);
        public void ConsultTransactions();
    }
}
