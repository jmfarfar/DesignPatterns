using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Models
{
    internal class Account
    {
        private int idAccount;
        private string user;
        private double initialBalance;

        public Account(int idAccount, string user, double initialBalance)
        {
            this.idAccount = idAccount;
            this.user = user;
            this.initialBalance = initialBalance;
        }

        public int GetIdAccount() => idAccount;

        public void SetIdAccount(int idAccount) => this.idAccount = idAccount;

        public string GetUser() => user;

        public void SetUser(string user) => this.user = user;

        public double GetInitialBalance() => this.initialBalance;

        public void SetInitialBalance(double ammount) => this.initialBalance = ammount;
        
    }
}
