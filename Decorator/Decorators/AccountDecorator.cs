using Decorator.Interfaces;
using Decorator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    internal abstract class AccountDecorator : IAccount
    {
        protected IAccount decoratedAccount;

        public AccountDecorator(IAccount decoratedAccount)
        {
            this.decoratedAccount = decoratedAccount;
        }

        public virtual void OpenAccount(Account acc)
        {
            this.decoratedAccount.OpenAccount(acc);
        }        
    }
}
