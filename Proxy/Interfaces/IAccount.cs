using Proxy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Interfaces
{
    internal interface IAccount
    {
        Account WithdrawMoney(Account acc, double ammount);
        Account DepositMoney(Account acc, double ammount);
        void ShowBalance(Account account);
    }
}
