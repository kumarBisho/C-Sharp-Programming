using System;

namespace Encapsulation
{
    public class Account
    {
        private float balance = 0;
        private string name = "";

        public string Name
        {
            get { return name; }
            set { if (!string.IsNullOrEmpty(value)) name = value; }
        }

        public void Deposit(float amount)
        {
            if(amount > 0)
            {
                balance += amount;
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        public void Withdraw(float amount)
        {
            if(amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("Withdrawal of " + amount + " successful.");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount.");
            }
        }

        public float GetBalance()
        {
            return balance;
        }
    }
}