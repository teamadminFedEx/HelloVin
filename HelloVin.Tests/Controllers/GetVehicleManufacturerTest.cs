using HelloVin.Controllers;
using HelloVin.Models.Enums;
using NUnit.Framework;

namespace HelloVin.Tests.Controllers
{
    [TestFixture]
    public class GetVehicleManufacturerTest
    {
        private VehicleManufacturerController _controller;

        [SetUp]
        public void SetUp()
        {
            _controller = new VehicleManufacturerController();
        }
        [Test]
        public void ShouldRecognizeSwedishScaniaVinInUpperCase()
        {
            //Arrange
            var testVin = "YS2"+"123456789ABCDE";
            
            
            //Act
            var resultingCompany = _controller.Get(testVin);
            //Assert
            Assert.AreEqual(VehicleManufacturer.Scania, resultingCompany);
        }
        [Test]
        public void ShouldRecognizeSwedishScaniaVinInLoweCase()
        {
            //Arrange
            var testVin = "ys2" + "123456789ABCDE";


            //Act
            var resultingCompany = _controller.Get(testVin);
            //Assert
            Assert.AreEqual(VehicleManufacturer.Scania, resultingCompany);
        }
    }


}