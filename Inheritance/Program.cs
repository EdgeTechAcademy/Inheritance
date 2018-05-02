using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            int balance;
            string accountName;
            int menuOption = 0;

            while (menuOption != 1)
            {
                menuOption = GetNumber("1 - Exit\n2 - Create Checking\n3 - Create Savings");
                switch (menuOption)
                {
                    //  exit the ATM
                    case 1:
                        break;

                    case 2:
                        accountName = GetInput("Account Name");
                        balance = GetNumber("Initial Amt: ");
                        Checking checking = new Checking(accountName, balance, 0.02f);
                        break;

                    case 3:
                        accountName = GetInput("Account Name");
                        balance = GetNumber("Initial Amt: ");
                        Savings savings = new Savings(accountName, balance, 0.02f);
                        break;

                    default:
                        break;
                }
            }
            Console.ReadLine();
        }

        public static string GetInput(string prompt)
        {
            Console.Write(prompt);
            string str = Console.ReadLine();
            return str;
        }
        public static int GetNumber(string prompt)
        {
            int userNumber;
            string strNumber = GetInput(prompt);
            while (!Int32.TryParse(strNumber, out userNumber))
            {
                Console.WriteLine("That is not an integer");
                strNumber = GetInput(prompt);
            }
            return userNumber;
        }
    }
}
