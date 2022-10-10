using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Interfaces;

namespace Factory.Implementations
{
    public class MySqlConnection : IConnection
    {
        private string host;
        private string port;
        private string user;
        private string password;


        public MySqlConnection()
        {
            this.host = "localhost";
            this.port = "8000";
            this.user = "Jhon";
            this.password = "abc123";
        }

        public void Connect()
        {
            Console.WriteLine("Connected to MySql");
        }

        public void Disconnect()
        {
            Console.WriteLine("Disconnected from MySql");
        }
    }
}
