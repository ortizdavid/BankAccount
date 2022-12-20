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
        public int Number { get; set;  }
        public double Balance { get; }
        public ICustomer? Customer { get; set; }
        public AccountStatus Status { get; set; }
        public void Withdraw(double ammount);
        public void Deposit(double amount);
        public void Transfer(IAccount origin, IAccount destination, double amount);
        public void ConsultTransactions();
    }
}
