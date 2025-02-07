using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class BankAccount
    {
        // Private field (hidden from outside)
        private double balance;

        // Public property to read the balance (only getter)
        public double Balance
        {
            get { return balance; }  // Read-only property
        }

        // Constructor to initialize balance
        public BankAccount(double initialBalance)
        {
            if (initialBalance >= 0)
                balance = initialBalance;
            else
                balance = 0;
        }

        // Public method to deposit money (controlled access)
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited: {amount}, New Balance: {balance}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        // Public method to withdraw money (controlled access)
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn: {amount}, Remaining Balance: {balance}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient balance.");
            }
        }
    }
}
