namespace BankingApp
{
    public interface IAccount
    {
        void Withdraw(decimal amount);
        void Deposit(decimal amount);
        string CheckBalance();
    }
}