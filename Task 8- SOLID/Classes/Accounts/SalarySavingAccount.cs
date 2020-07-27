namespace Accounts.AccountTypes
{
    public class SalarySavingAccount : SavingAccount
    {
        public override bool Withdraw(decimal amount)
        {
            var moneyAfterWithdraw = Balance - amount;
            if (moneyAfterWithdraw >= 0)
            {
                Balance = moneyAfterWithdraw;
                return true;
            }

            return false;
        }
    }
}