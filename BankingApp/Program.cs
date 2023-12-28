using System;

namespace BankingApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Creating accounts
            var acc1 = new SavingsAccount(0);
            var acc2 = new CheckingAccount(0, 100);
            var acc3 = new FixedDepositAccount(0, DateTime.Parse("12/29/23"));
            //Depositing some money to the accounts
            acc1.Deposit(200);
            acc2.Deposit(200);
            acc3.Deposit(200);
            //Withdrawing from the accounts
            acc1.Withdraw(150);
            acc2.Withdraw(90);
            //acc2.Withdraw(101); Throws an Exception 
            //acc3.Withdraw(1); Throws an Exception
            Console.WriteLine(acc1.CheckBalance());
            Console.WriteLine(acc2.CheckBalance());
            Console.WriteLine(acc3.CheckBalance());
        }
    }
}