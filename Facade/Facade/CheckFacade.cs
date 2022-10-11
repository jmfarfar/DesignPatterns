using Facade.APIs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Facade
{
    internal class CheckFacade
    {
        private FlightAPI _flightAPI;
        private HotelAPI _hotelAPI;

        public CheckFacade()
        {
            _flightAPI = new FlightAPI();
            _hotelAPI = new HotelAPI();
        }

        public void Search(string name, string fromDate, string toDate, string departureLocation, string targetLocation)
        {
            _flightAPI.SearchFlights(fromDate, toDate, departureLocation, targetLocation);
            _hotelAPI.SearchHotel(fromDate, toDate, name);
        }
    }
}
