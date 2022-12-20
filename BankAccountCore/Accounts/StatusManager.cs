using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Accounts
{
    public enum AccountStatus
    {
        Inactive,
        Active,
        Pendding,
    }

    public enum TransactionStatus
    { 
        OnProgress,
        Succeeded,
        Fail, 
    }
}
