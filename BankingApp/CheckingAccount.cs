using System;

namespace BankingApp
{
    public class CheckingAccount:IAccount
    {
        private decimal Balance { get; set; }
        private decimal Overdraft { get; set; }
        public CheckingAccount(decimal balance, decimal overdraft)
        {
            if (balance < 0 || overdraft < 0)
            {
                throw new ArgumentException("Invalid balance or overdraft value");
            }
            Balance = balance;
            Overdraft = overdraft;
        }
        public string CheckBalance()
        {
            return $"Account Balance = {Balance}";
        }
        public void Withdraw(decimal amount)
        {
            if (amount <= Overdraft)
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