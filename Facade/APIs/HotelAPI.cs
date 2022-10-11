using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.APIs
{
    internal class HotelAPI
    {

        public void SearchHotel(string arrivingDate, string checkOut, string reservationName)
        {
            Console.WriteLine($"Hotel found from: {arrivingDate} to {checkOut}");
            Console.WriteLine($"Reservation name: {reservationName}");
        }
    }
}
