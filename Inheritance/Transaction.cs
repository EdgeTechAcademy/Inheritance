using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Transaction
    {
        private DateTime timestamp;
        private bool successful;
        private decimal amount;
        private string type;

        public DateTime Timestamp { get => timestamp; set => timestamp = value; }
        public bool Successful { get => successful; set => successful = value; }
        public decimal Amount { get => amount; set => amount = value; }
        public string Type { get => type; set => type = value; }

        public Transaction(decimal amount, string type, bool success)
        {
            this.amount = amount;
            this.type = type;
            this.timestamp = DateTime.Now;
            this.successful = success;
        }
    }
}
