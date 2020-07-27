namespace Accounts.AccountTypes
{
    public class RegularSavingAccount : SavingAccount
    {
        public override bool Withdraw(decimal amount)
        {
            var moneyAfterWithdrawal = Balance - amount;
            if (moneyAfterWithdrawal >= 1000)
            {
                Balance = moneyAfterWithdrawal;
                return true;
            }

            return false;
        }
    }
}