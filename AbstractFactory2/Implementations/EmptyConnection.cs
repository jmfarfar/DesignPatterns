using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory2.Interfaces;

namespace AbstractFactory2.Implementations
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
