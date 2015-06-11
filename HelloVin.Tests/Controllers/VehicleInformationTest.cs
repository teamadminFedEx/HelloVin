using System.Collections.Generic;
using System.Data;
using System.Linq;
using HelloVin.Interfaces;
using HelloVin.Models;
using HelloVin.Models.Properties;
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
            var propertyList = new List<IVehiclePropertyGenerator>()
            {
                new ManufacturerProperty(),
                new VehicleTypeProperty()
            };
            var vehicleInformation = new VehicleInformation(propertyList);
            // act
            var result = vehicleInformation.Get(testVin);
            // Assert
            Assert.AreEqual(result.Count(), propertyList.Count());

        }

    }
}