using System;
using System.Collections.Generic;
using System.Text;

namespace Accounts
{
    public abstract class SavingAccount : SavingAccountReadOnly
    {
        public abstract bool Withdraw(decimal amount);
    }
}
