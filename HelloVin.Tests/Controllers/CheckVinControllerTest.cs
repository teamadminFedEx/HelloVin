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
        public void GetByVin()
        {
            // Arrange
            CheckVinController controller = new CheckVinController();

            // Act
            string result = controller.Get("123");

            // Assert
            Assert.AreEqual("Not ok", result);
        }
    }
}
