using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Accounts
{
    public class Transaction
    {
        public int TransactionNumber 
        {  
            get { return (int)(new Random()).Next(1, 100); }
        }
        public int Origin { get; set; }
        public int Destiny { get; set; }
        public double Amount { get; set; }
        public TransactionStatus Status { get; set; }
        public string TransactionType { get; set; }
        public DateTime TransactionDate { get; set; }

        public override string ToString()
        {
            return String.Format("{0}\t\t{1}\t\t{2}\t\t{3:C}\t\t{4}\t\t{5:dd/MM/yyy hh:mm:ss}\n",
                TransactionNumber, Origin, Destiny, Amount, TransactionType, TransactionDate);
        }
    }
}
