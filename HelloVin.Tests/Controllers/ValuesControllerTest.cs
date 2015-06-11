using System.Collections.Generic;
using System.Linq;
using HelloVin.Controllers;
using NUnit.Framework;

namespace HelloVin.Tests.Controllers
{
    [TestFixture]
    public class ValuesControllerTest
    {

        [Test]
        public void Get()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            IEnumerable<string> result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count());
            Assert.AreEqual("value1", result.ElementAt(0));
            Assert.AreEqual("value2", result.ElementAt(1));
            Assert.AreEqual("A_New_Value", result.ElementAt(2));
        }

        [Test]
        public void GetById()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            const int Id = 5;

            // Act
            string result = controller.Get(Id);

            // Assert
            Assert.AreEqual("value: " + Id, result);
        }

        [Test]
        public void Post()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            controller.Post("value");

            // Assert
        }

        [Test]
        public void Put()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            controller.Put(5, "value");

            // Assert
        }

        [Test]
        public void Delete()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            controller.Delete(5);

            // Assert
        }
    }
}
