using System;

namespace BankingApp
{
    public class SavingsAccount:IAccount
    {
        private decimal Balance { get; set; }
        public SavingsAccount(decimal balance)
        {
            if (balance < 0)
            {
                throw new ArgumentException("Invalid value for Balance");
            }

            Balance = balance;
        }
        public string CheckBalance()
        {
            return $"Account Balance = {Balance}";
        }
        public void Withdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
            }
        }
        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Invalid deposit value");
            }

            Balance += amount;
        }
    }
}