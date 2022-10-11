using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    internal class Account
    {
        private int id;
        private double balance;

        public Account(int id, int balance)
        {
            this.id = id;
            this.balance = balance;
        }

        public void Withdraw(double ammount)
        {
            balance -= ammount;
            Console.WriteLine($"[Command Withdraw] Account: {id} Balance: {balance}");
        }

        public void Deposit(double ammount)
        {
            balance += ammount;
            Console.WriteLine($"[Command Deposit] Account: {id} Balance: {balance}");
        }
    }
}
