using RestSharp1.DataModels;
using System;

namespace RestSharp1.Tests.TestData
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
