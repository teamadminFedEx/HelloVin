using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloVin;
using HelloVin.Controllers;

namespace HelloVin.Tests.Controllers
{
    [TestClass]
    public class CheckVinControllerTest
    {
        [TestMethod]
        public void GetByCorrectVin()
        {
            // Arrange
            CheckVinController controller = new CheckVinController();

            // Act
            var result = controller.Get("12345678901234567");

            // Assert
            Assert.AreEqual("Ok!!", result);
        }

        [TestMethod]
        public void GetByIncorrectVin()
        {
            // Arrange
            CheckVinController controller = new CheckVinController();

            // Act
            var result = controller.Get("123");

            // Assert
            Assert.AreEqual("Not Ok!", result);
        }
    }
}
