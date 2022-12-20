using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Accounts
{
    public class Transaction
    {
        public int TransactionNumber { get; set; }
        public string Origin { get; set; }
        public string Destiny { get; set; }
        public double Amount { get; set; }
        public TransactionStatus Status { get; set; }
        public string TransactionType { get; set; }
        public DateTime TransactionDate { get; set; }

        public string ToString()
        {
            return String.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5:dd/MM/yyy hh:mm:ss}t\n",
                TransactionNumber, Origin, Destiny, Amount, TransactionType, TransactionDate);
        }
    }
}
