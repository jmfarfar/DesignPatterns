using AbstractFactory2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory2
{
    internal class FactoryProducer
    {

        public static IAbstractFactory GetFactory(string factory) => factory switch
        {
            "DB" => new FactoryDB(),
            "REST" => new FactoryREST(),
            _ => throw new NotImplementedException()
        };
    }
}
