using Decorator.Interfaces;
using Decorator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Implementations
{
    internal class DebitAccount : IAccount
    {
        public void OpenAccount(Account acc)
        {
            Console.WriteLine("Debit account created");
            Console.WriteLine($"Client: {acc.GetClient()}");
        }
    }
}
