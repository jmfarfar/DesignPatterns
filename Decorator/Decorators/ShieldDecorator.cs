using Decorator.Interfaces;
using Decorator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    internal class ShieldDecorator : AccountDecorator
    {
        public ShieldDecorator(IAccount decoratedAccount) : base(decoratedAccount)
        {
        }

        public override void OpenAccount(Account acc)
        {
            decoratedAccount.OpenAccount(acc);
            AddShield(acc);
        }    
        
        public void AddShield(Account acc)
        {
            Console.WriteLine($"Shield added to client's the account: {acc.GetClient()}");
        }
    }
}
