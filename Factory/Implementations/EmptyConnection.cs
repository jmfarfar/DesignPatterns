using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Interfaces;

namespace Factory.Implementations
{
    internal class EmptyConnection : IConnection
    {
        public void Connect()
        {
            Console.WriteLine("Database provider not specified");
        }

        public void Disconnect()
        {
            Console.WriteLine("Database provider not specified");
        }
    }
}
