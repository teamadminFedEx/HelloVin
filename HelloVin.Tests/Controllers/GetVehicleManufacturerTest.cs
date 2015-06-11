using HelloVin.Controllers;
using HelloVin.Models.Enums;
using NUnit.Framework;

namespace HelloVin.Tests.Controllers
{
    [TestFixture]
    public class GetVehicleManufacturerTest
    {
        private GetVehicleManufacturerController _controller;

        [SetUp]
        public void SetUp()
        {
            _controller = new GetVehicleManufacturerController();
        }
        [Test]
        public void ShouldRecognizeSwedishScaniaVin()
        {
            //Arrange
            var testVin = "YS2"+"123456789ABCDE";
            
            
            //Act
            var resultingCompany = _controller.Get(testVin);
            //Assert
            Assert.AreEqual(VehicleManufacturer.Scania, resultingCompany);
        }
    }


}