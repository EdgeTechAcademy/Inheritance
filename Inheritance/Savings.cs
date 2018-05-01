using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Savings : Account
    {
        public Savings(string accountName, decimal balance, float interestRate) : base(accountName, balance, interestRate)
        {
        }
    }
}
