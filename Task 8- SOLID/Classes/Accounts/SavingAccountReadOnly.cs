using System.Reflection.Metadata;

namespace Accounts
{
    public abstract class SavingAccountReadOnly
    {
        public decimal Balance { get; set; }
        //public abstract bool Withdraw(decimal amount);
    }
}