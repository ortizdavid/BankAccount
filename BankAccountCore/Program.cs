using BankAccount;
using BankAccount.Accounts;
using BankAccount.Customers;
using static System.Console;

internal class Program
{
    private static void Main(string[] args)
    {
        IAccount saving = new SavingsAccount
        {
            Number = 001,
            Status = AccountStatus.Active,
            Customer = new IndividualCustomer(),
        };
        saving.Deposit(89);
        saving.Deposit(90);
        saving.Withdraw(89);
        saving.Deposit(90000);
        saving.Withdraw(89);
        saving.Deposit(90);
        saving.ConsultTransactions();
        WriteLine(saving.Status);
        WriteLine(saving.Balance);

    }
}