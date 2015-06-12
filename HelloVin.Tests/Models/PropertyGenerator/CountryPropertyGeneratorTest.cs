using System.Collections.Generic;
using HelloVin.Interfaces;
using HelloVin.Models.PropertyGenerator;
using NUnit.Framework;

namespace HelloVin.Tests.Models.PropertyGenerator
{
    [TestFixture]
    public class CountryPropertyGeneratorTest
    {
        [Test]
        [TestCaseSource("SwedenVin")]
        public void CountryProperty_ShouldDetectSweden(string testVin)
        {
            var countryProperty = new CountryProperty();
            IVehicleProperty property = countryProperty.GetVehicleProperty(testVin);

            Assert.That(property.Property, Is.EqualTo("Country"));
            Assert.That(property.Value, Is.EqualTo("Sweden"));
        }

        public IEnumerable<string> SwedenVin()
        {
            for (char c = 'S'; c <= 'W'; c++)
            {
                yield return "Y" + c;
            }
        }

        [Test]
        [TestCaseSource("NotSwedenVin")]
        public void CountryProperty_ShouldDetectNotSweden(string testVin)
        {
            var countryProperty = new CountryProperty();
            IVehicleProperty property = countryProperty.GetVehicleProperty(testVin);

            Assert.That(property.Property, Is.EqualTo("Country"));
            Assert.That(property.Value, Is.Not.EqualTo("Sweden"));
        }

        public IEnumerable<string> NotSwedenVin()
        {
            char c = (char) ('S' - 1);
            yield return "Y" + c;
            c = (char) ('W' + 1);
            yield return "Y" + c;
        }

        [Test]
        public void CountryProperty_ShouldDetectSwedenCaseInsensitive()
        {
            string testVin = "ys2";

            var countryProperty = new CountryProperty();
            IVehicleProperty property = countryProperty.GetVehicleProperty(testVin);

            Assert.That(property.Property, Is.EqualTo("Country"));
            Assert.That(property.Value, Is.EqualTo("Sweden"));
        }

    }
}
