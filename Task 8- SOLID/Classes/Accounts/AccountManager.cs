namespace Accounts
{
    public class AccountManager
    {
        public static bool WithdrawFrom(SavingAccount accountReadOnly, decimal amount)
        {
            return accountReadOnly.Withdraw(amount);
        }
    }
}