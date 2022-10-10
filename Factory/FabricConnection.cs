using Factory.Implementations;
using Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class FabricConnection
    {
        // This fabric manages which implementation to return. We specify the return value as IConnection because this way we do not need to generate a GetConnection method
        // for every provider we have and will have. 
        // For new providers we just need to add a new line into our method without change the composition of our fabric class.
        public IConnection GetConnection(string provider) => provider switch
        {
            "MySql" => new MySqlConnection(),
            "Oracle" => new OracleConnection(),
            "SqlServer" => new SqlServerConnection(),
            _ => new EmptyConnection()

        };
    }
}
