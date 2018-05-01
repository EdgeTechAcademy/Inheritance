using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Checking : Account
    {
        private Account overdraftProtecion;

        public Account OverdraftProtecion { get => overdraftProtecion; set => overdraftProtecion = value; }

        public Checking(string accountName, decimal balance, float interestRate) : base(accountName, balance, interestRate)
        {
            Console.WriteLine("Create Checking");
        }

        public void Withdrawal(decimal amount)
        {
            if (amount > Balance)
            {
                if (OverdraftProtecion != null && amount > Balance + OverdraftProtecion.Balance)
                {
                    Transaction transaction = new Transaction(amount, "Account Withdrawal Failed", false);
                    Transactions.Add(transaction);
                }
                else
                {
                    decimal tempAmount = amount;
                    tempAmount -= Balance;
                    Balance = 0;
                    OverdraftProtecion.Balance -= tempAmount;
                    Transaction transaction = new Transaction(amount, "Account Withdrawal Succeeded", true);
                }
            }
            else
            {
                Transaction transaction = new Transaction(amount, "Account Withdrawal Succeeded", true);
                Transactions.Add(transaction);
            }
        }
    }
}
