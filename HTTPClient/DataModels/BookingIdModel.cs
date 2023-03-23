﻿using Newtonsoft.Json;

namespace HTTPClient.DataModels
{
    class BookingIdModel
    {
        [JsonProperty("bookingid")]
        public int BookingId { get; set;}

        [JsonProperty("booking")]
        public BookingDetailsModel Booking { get; set;}
    }
}
