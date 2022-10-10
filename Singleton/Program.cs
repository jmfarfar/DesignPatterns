
using Singleton;

namespace Singleton;

public class Program
{

    public static void Main(string[] args)
    {
        // This cannot be possible due the nature of a Singleton. We cannot create a new instance of Connection!
        //public Connection MyConnection = new Connection();



        // Instead we can retrieve or create the instance from the proper Connection class.
        Connection MySingletonConnection = Connection.GetInstance();
        MySingletonConnection.Connect();        
        MySingletonConnection.Disconnect();

        Connection AnotherSingConnection = Connection.GetInstance();
        AnotherSingConnection.Connect();
        AnotherSingConnection.Disconnect();


        // with this comparison we demonstrate that both variables of Connection have the same instance.
        Console.WriteLine(MySingletonConnection.Equals(AnotherSingConnection));

    }


}