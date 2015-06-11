using HelloVin.Controllers;
using HelloVin.Models.DataContract;
using NUnit.Framework;

namespace HelloVin.Tests.Controllers
{
    [TestFixture]
    public class CheckVinControllerTest
    {
        [Test]
        public void GetByCorrectVin()
        {
            // Arrange
            CheckVinController controller = new CheckVinController();

            // Act
            var result = controller.Get("12345678901234567");

            // Assert
            Assert.AreEqual(CheckResult.Ok, result.CheckResult);
        }

        [Test]
        public void GetByIncorrectVin()
        {
            // Arrange
            CheckVinController controller = new CheckVinController();

            // Act
            var result = controller.Get("123");

            // Assert
            Assert.AreEqual(CheckResult.Failed, result.CheckResult);
        }
    }
}
