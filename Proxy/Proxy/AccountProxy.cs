using Proxy.Implementations;
using Proxy.Interfaces;
using Proxy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Proxy
{
    internal class AccountProxy : IAccount
    {
        private IAccount? realAcc;

        public AccountProxy(IAccount realAccount)
        {
            realAcc = realAccount;
        }

        public Account DepositMoney(Account acc, double ammount)
        {
            if (realAcc == null)
            {
                realAcc = new BankAccount();
                return realAcc.DepositMoney(acc, ammount);
            }
            return realAcc.DepositMoney(acc, ammount);
        }

        public void ShowBalance(Account account)
        {
            if (realAcc == null)
            {
                realAcc = new BankAccount();
                realAcc.ShowBalance(account);
            }
            realAcc.ShowBalance(account);
        }

        public Account WithdrawMoney(Account acc, double ammount)
        {
            if (realAcc == null)
            {
                realAcc = new BankAccount();
                return realAcc.WithdrawMoney(acc, ammount);
            }
            return realAcc.WithdrawMoney(acc, ammount);
        }
    }
}
