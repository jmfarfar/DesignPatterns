using Proxy.Interfaces;
using Proxy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Implementations
{
    internal class BankAccount : IAccount
    {
        public Account DepositMoney(Account acc, double ammount)
        {
            double currentBalance = acc.GetInitialBalance() + ammount;
            acc.SetInitialBalance(currentBalance);
            Console.WriteLine($"Your money has been deposited successfully. Your current balance is {acc.GetInitialBalance()}");
            return acc;
        }

        public void ShowBalance(Account account)
        {
            Console.WriteLine($"Current Balance: {account.GetInitialBalance()}");
        }

        public Account WithdrawMoney(Account acc, double ammount)
        {
            double currentBalance = acc.GetInitialBalance() - ammount;
            acc.SetInitialBalance(currentBalance);
            Console.WriteLine($"Withdraw money successfully. Your current balance is {acc.GetInitialBalance()}");
            return acc;
        }
    }
}
