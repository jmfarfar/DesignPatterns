using Prototype.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Models
{
    internal class SavingAccount : ICloneable
    {

        private string type;
        private double amount;

        public SavingAccount()
        {
            type = "Savings";
        }

        public object Clone() => this.MemberwiseClone();

        public override string ToString() => "SavingAccount [type= " + type + ", ammount = " + amount + "]";

        public void SetAmmount(double amount) => this.amount = amount;

        public double GetAmmount() => amount;

    }
}
