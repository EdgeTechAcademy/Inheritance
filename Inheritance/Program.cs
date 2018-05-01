using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("Just an Account", 1000, 0.02f);
            account.Deposit(100);
            account.Deposit(200);
            account.Withdrawal(400);
            account.Deposit(300);
            account.Withdrawal(1100);
            account.Withdrawal(100);
            account.ShowTransactions();
            //Checking checking = new Checking("Family Account", 1000);
            //Savings savings = new Savings("Savings Account", 1000);
            //checking.OverdraftProtecion = savings;
            Console.ReadLine();
        }
    }
}
