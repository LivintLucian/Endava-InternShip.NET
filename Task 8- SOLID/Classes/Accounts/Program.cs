using Accounts.AccountTypes;

namespace Accounts
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SavingAccount account1 = new RegularSavingAccount();
            SavingAccount accountReadOnly = new SalarySavingAccount();
            SavingAccountReadOnly account3 = new FixDepositSavingAccount();

            AccountManager.WithdrawFrom(account1, 100);
            AccountManager.WithdrawFrom(accountReadOnly, 200);
            AccountManager.WithdrawFrom(account3, 300);
        }
    }
}