using AbstractFactory2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory2.Implementations
{
    internal class ConnectionRESTShop : IConnectionREST
    {
        public void readURL(string url)
        {
            Console.WriteLine("Shop Department");
        }
    }
}
