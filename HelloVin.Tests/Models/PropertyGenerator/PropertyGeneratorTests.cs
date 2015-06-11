using HelloVin.Models.Properties;
using NUnit.Framework;

namespace HelloVin.Tests.Models.PropertyGenerator
{
    [TestFixture]
    public class PropertyGeneratorTests
    {
        [Test]
        public void ManufacturerProperty_DetectsScania()
        {
            var testVin = "YS2" + "123456789ABCDE";
            var manufacturerproperty = new ManufacturerProperty();
            var result = manufacturerproperty.GetVehicleProperty(testVin);

            Assert.AreEqual(result.Property, "Manufacturer");
            Assert.AreEqual(result.Value, "Scania");
        }

        [Test]
        public void ManufacturerProperty_DefaultsUnknown()
        {
            var testVin = "ÄÄÄ" + "123456789ABCDE";
            var manufacturerproperty = new ManufacturerProperty();
            var result = manufacturerproperty.GetVehicleProperty(testVin);

            Assert.AreEqual(result.Property, "Manufacturer");
            Assert.AreEqual(result.Value, "Unknown");
        }
    }
}