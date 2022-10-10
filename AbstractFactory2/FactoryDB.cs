using AbstractFactory2.Implementations;
using AbstractFactory2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory2
{
    internal class FactoryDB : IAbstractFactory
    {
        public IConnection getDB(string provider) => provider switch
        {
            "MySql" => new MySqlConnection(),
            "Oracle" => new OracleConnection(),
            "SqlServer" => new SqlServerConnection(),
            _ => new EmptyConnection()
        };

        public IConnectionREST getREST(string area)
        {
            return null;
        }
    }
}
