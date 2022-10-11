using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    internal class Withdraw : IOperation
    {
        private Account _account;
        private double _amount;

        public Withdraw(Account account, double amount)
        {
            _account = account;
            _amount = amount;
        }

        public void Execute()
        {
            _account.Withdraw(_amount);
        }
    }
}
