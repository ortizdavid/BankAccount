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
            Number = "001",
            Status = AccountStatus.Active,
            Customer = new IndividualCustomer(),
        };
        saving.Deposit(-9);
        saving.Deposit(1000);
        saving.ConsultTransactions();
        WriteLine(saving.Status);

    }
}