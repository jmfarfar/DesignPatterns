using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Connection
    {
        private static Connection? _instance;

        // this is how we identify and/or create a singleton
        private Connection() { }
        

        // we need a method to retrieve the actual status of our singleton, to see if it has been already instantiated and return the instance.
        public static Connection GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Connection();
            }
            return _instance;
        }

        public void Connect()
        {
            Console.WriteLine("Connection to DB...");
        }

        public void Disconnect()
        {
            Console.WriteLine("Disconnection to DB...");
        }
    }
}
