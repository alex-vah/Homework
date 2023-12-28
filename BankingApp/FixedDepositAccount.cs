using System;

namespace BankingApp
{
    public class FixedDepositAccount:IAccount
    {
        private DateTime MaturityDt { get; set; }
        private decimal Balance { get; set; }
        public FixedDepositAccount(decimal balance, DateTime dt)
        {
            if (balance < 0 || DateTime.Compare(dt, DateTime.Now) < 0)
            {
                throw new Exception("Invalid balance or maturity date  value");
            }
            Balance = balance;
            MaturityDt = dt;
        }
        public string CheckBalance()
        {
            return $"Account Balance = {Balance}";
        }
        public void Withdraw(decimal amount)
        {
            if (DateTime.Compare(MaturityDt, DateTime.Now) <= 0 && amount>=0)
            {
                if (amount <= Balance)
                { 
                    Balance -= amount; 
                }
            }
            else
            {
                throw new Exception("Withdrawal impossible, Maturity date not reached.");
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