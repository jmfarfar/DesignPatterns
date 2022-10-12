using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.DAO
{
    internal class ConnectionPostgress : IConnection
    {
        private string user;
        private string password;
        private string host;

        public ConnectionPostgress(string user, string password, string host)
        {
            this.user = user;
            this.password = password;
            this.host = host;
        }

        public void Connect()
        {
            Console.WriteLine("Connection to Postgress");
        }
    }
}
