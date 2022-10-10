using AbstractFactory2.Implementations;
using AbstractFactory2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory2
{
    internal class FactoryREST : IAbstractFactory
    {
        public IConnection getDB(string provider)
        {
            return null;
        }

        public IConnectionREST getREST(string area) => area switch
        {
            "Sales" => new ConnectionRESTSales(),
            "Shop" => new ConnectionRESTShop(),
            _ => new ConnectionRESTNoArea()
        };
    }
}
