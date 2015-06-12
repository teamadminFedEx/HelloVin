using System.Collections.Generic;
using System.Linq;
using HelloVin.Interfaces;
using HelloVin.Models;
using HelloVin.Models.PropertyGenerator;
using NUnit.Framework;

namespace HelloVin.Tests.Controllers
{
    [TestFixture]
    public class VehicleInformationTest
    {
        [Test]
        public void Get_AllPropertyGeneratorsAreCalled()
        {
            // Arrange
            var testVin = "YS2" + "123456789ABCDE";
            var propertyList = new List<IVehiclePropertyGenerator>
            {
                new ManufacturerProperty(),
                new VehicleTypeProperty(),
                new CountryProperty()
            };
            var vehicleInformation = new VehicleInformation(propertyList, testVin);
            // act
            var result = vehicleInformation.VehicleProperties;
            // Assert
            Assert.AreEqual(result.Count(), propertyList.Count());
        }
    }
}