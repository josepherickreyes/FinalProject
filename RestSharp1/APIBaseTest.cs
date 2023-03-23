using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using RestSharp1.DataModels;

namespace RestSharp1.Tests
{
    public class APIBaseTest
    {
        public RestClient RestClient { get; set; }
        public BookingIdModel BookingDetails { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            RestClient = new RestClient();
        }
    }
}
