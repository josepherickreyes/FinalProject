using RestSharp1.DataModels;

namespace RestSharp1.Tests.TestData
{
    public class AuthTokenDetails
    {
        public static TokenDetailsModel credentials()
        {
            return new TokenDetailsModel
            {
                Username = "admin",
                Password = "password123"
            };
        }
    }
}
