using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory2.Interfaces;

namespace AbstractFactory2.Implementations
{
    public class OracleConnection : IConnection
    {
        private string host;
        private string port;
        private string user;
        private string password;

        public OracleConnection()
        {
            this.host = "localhost";
            this.port = "8000";
            this.user = "Jhon";
            this.password = "abc123";
        }

        public void Connect()
        {
            Console.WriteLine("Connected to Oracle");
        }

        public void Disconnect()
        {
            Console.WriteLine("Disconnected from Oracle");
        }
    }
}
