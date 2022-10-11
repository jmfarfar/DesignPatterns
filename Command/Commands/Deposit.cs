using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    internal class Deposit : IOperation
    {
        private Account _account;
        private double _amount;

        public Deposit(Account account, double amount)
        {
            _account = account;
            _amount = amount;
        }

        public void Execute()
        {
            _account.Deposit(_amount);
        }
    }
}
