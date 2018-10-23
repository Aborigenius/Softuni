using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLesson
{
    public class BankAccount
    {
        private int id;
        private decimal balance;

        //auto property
        //public decimal Balance { get; set; }
        public decimal Balance
        {
            get
            {
                return balance;
            }

        }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public decimal Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                return amount;
            }
            else
            {
                throw new ArgumentException("Insufficient Amount");
            }
           
        }

        public override string ToString()
        {
            return $"Your balance is: {balance.ToString()}";
        }
    }
}
