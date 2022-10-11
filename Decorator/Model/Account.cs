using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Model
{
    internal class Account
    {
        private int Id;
        private string client;

        public Account()
        {

        }

        public Account(int id, string client)
        {
            this.Id = id;
            this.client = client;
        }

        public int GetId() => Id;
        
        public void SetId(int id) => this.Id = id;

        public string GetClient() => client;
    }
}
