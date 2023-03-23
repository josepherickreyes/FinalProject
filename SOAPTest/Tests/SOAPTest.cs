using Microsoft.VisualStudio.TestTools.UnitTesting;
using CountryInfoServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: Parallelize(Workers = 10, Scope = ExecutionScope.MethodLevel)]
namespace SOAPTest
{
    [TestClass]
    public class SOAPTest
    {
        private readonly CountryInfoServiceReference.CountryInfoServiceSoapTypeClient _CountryInfoService =
            new CountryInfoServiceReference.CountryInfoServiceSoapTypeClient(CountryInfoServiceReference.CountryInfoServiceSoapTypeClient.EndpointConfiguration.CountryInfoServiceSoap);

        private tCountryCodeAndName[] ReturnCountryCodeAndNameList()
        {
            CountryInfoServiceReference.tCountryCodeAndName[] listOfCountryNamesByCode = _CountryInfoService.ListOfCountryNamesByCode();
            return listOfCountryNamesByCode;
        }

        private tCountryCodeAndName ReturnRandomCountryCode(tCountryCodeAndName[] listOfCountryNamesByCode)
        {
            Random r = new Random();
            long randomNumber = r.NextInt64(listOfCountryNamesByCode.Length);
            tCountryCodeAndName randomCountry = listOfCountryNamesByCode[randomNumber];
            return randomCountry;
        }

        [TestMethod]
        public void ValidateFullCountryInfo()
        {
            //Arrange
            var listOfCountryNamesByCode = ReturnCountryCodeAndNameList();

            //Act
            tCountryCodeAndName randomCountry = ReturnRandomCountryCode(listOfCountryNamesByCode);
            var fullCountryInfo = _CountryInfoService.FullCountryInfo(randomCountry.sISOCode);
            
            //Assert
            Assert.AreEqual(fullCountryInfo.sISOCode, randomCountry.sISOCode);
            Assert.AreEqual(fullCountryInfo.sName, randomCountry.sName);
        }

        [TestMethod]
        public void ValidateCountryISOCode()
        {
            //Arrange
            var listOfCountryNamesByCode = ReturnCountryCodeAndNameList();

            //Act
            tCountryCodeAndName randomCountry1 = ReturnRandomCountryCode(listOfCountryNamesByCode);
            tCountryCodeAndName randomCountry2 = ReturnRandomCountryCode(listOfCountryNamesByCode);
            tCountryCodeAndName randomCountry3 = ReturnRandomCountryCode(listOfCountryNamesByCode);
            tCountryCodeAndName randomCountry4 = ReturnRandomCountryCode(listOfCountryNamesByCode);
            tCountryCodeAndName randomCountry5 = ReturnRandomCountryCode(listOfCountryNamesByCode);
            var countryCode1 = _CountryInfoService.CountryISOCode(randomCountry1.sName);
            var countryCode2 = _CountryInfoService.CountryISOCode(randomCountry2.sName);
            var countryCode3 = _CountryInfoService.CountryISOCode(randomCountry3.sName);
            var countryCode4 = _CountryInfoService.CountryISOCode(randomCountry4.sName);
            var countryCode5 = _CountryInfoService.CountryISOCode(randomCountry5.sName);

            //Assert
            Assert.AreEqual(randomCountry1.sISOCode, countryCode1);
            Assert.AreEqual(randomCountry2.sISOCode, countryCode2);
            Assert.AreEqual(randomCountry3.sISOCode, countryCode3);
            Assert.AreEqual(randomCountry4.sISOCode, countryCode4);
            Assert.AreEqual(randomCountry5.sISOCode, countryCode5);
        }

    }
}
