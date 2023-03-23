using HTTPClient.DataModels;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTTPClient.Tests.TestData
{
    public class GenerateBookingDetails
    {
        public static BookingDetailsModel bookingDetails()
        {
            var checkInDate = new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            var checkOutDate = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);

            return new BookingDetailsModel
            {
                Firstname = "Kidd",
                Lastname = "Hibiki",
                Totalprice = 111,
                Depositpaid = true,
                Bookingdates = new Bookingdates() { Checkin = checkInDate, Checkout = checkOutDate },
                Additionalneeds = "Breakfast"
            };
        }
    }
}
