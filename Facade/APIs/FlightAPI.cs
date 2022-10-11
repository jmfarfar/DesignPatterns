using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.APIs
{
    internal class FlightAPI
    {
        
        public void SearchFlights(string departureDate, string returnDate, string departureLocation, string targetLocation)
        {
            Console.WriteLine($"Found flights to {targetLocation} from {departureLocation}");
            Console.WriteLine($"Initial date: {departureDate} | Return date: {returnDate}");
        }
    }
}
