using HelloVin.Models.PropertyGenerator;
using NUnit.Framework;

namespace HelloVin.Tests.Models.PropertyGenerator
{
    [TestFixture]
    public class ManufacturerPropertyGeneratorTest
    {
        [Test]
        public void ManufacturerProperty_DetectsScania([Values("YS2","YS4","VLU","9BS")] string id)
        {
            var testVin = id + "123456789ABCDE";
            var manufacturerproperty = new ManufacturerProperty();
            var result = manufacturerproperty.GetVehicleProperty(testVin);

            Assert.AreEqual(result.Property, "Manufacturer");
            Assert.AreEqual(result.Value, "Scania");
        }

        [Test]
        public void ManufacturerProperty_DetectsVolvo([Values("YV1","YV2","YV3","YV4","4V1", "4V2", "4V3", "4V4", "4V5", "4V6", "4VL", "4VM", "4VZ")] string id)
        {
            var testVin = id + "123456789ABCDE";
            var manufacturerproperty = new ManufacturerProperty();
            var result = manufacturerproperty.GetVehicleProperty(testVin);

            Assert.AreEqual(result.Property, "Manufacturer");
            Assert.AreEqual(result.Value, "Volvo");
        }

        
        [Test]
        public void ManufacturerProperty_DetectsRenault([Values("8A1", "93Y", "9FB", "KNM", "L56", "VF1", "VF6")] string id)
        {
            var testVin = id + "123456789ABCDE";
            var manufacturerproperty = new ManufacturerProperty();
            var result = manufacturerproperty.GetVehicleProperty(testVin);

            Assert.AreEqual(result.Property, "Manufacturer");
            Assert.AreEqual(result.Value, "Renault");
        }

        [Test]
        public void ManufacturerProperty_DetectsMan([Values("LZM", "WMA")] string id)
        {
            var testVin = id + "123456789ABCDE";
            var manufacturerproperty = new ManufacturerProperty();
            var result = manufacturerproperty.GetVehicleProperty(testVin);

            Assert.AreEqual(result.Property, "Manufacturer");
            Assert.AreEqual(result.Value, "Man");
        }

        [Test]
        public void ManufacturerProperty_DetectsIveco([Values("XLR", "XLV")] string id)
        {
            var testVin = id + "123456789ABCDE";
            var manufacturerproperty = new ManufacturerProperty();
            var result = manufacturerproperty.GetVehicleProperty(testVin);

            Assert.AreEqual(result.Property, "Manufacturer");
            Assert.AreEqual(result.Value, "Iveco");
        }

        [Test]
        public void ManufacturerProperty_DefaultsUnknown()
        {
            var testVin = "���" + "123456789ABCDE";
            var manufacturerproperty = new ManufacturerProperty();
            var result = manufacturerproperty.GetVehicleProperty(testVin);

            Assert.AreEqual(result.Property, "Manufacturer");
            Assert.AreEqual(result.Value, "Unknown");
        }
    }
}