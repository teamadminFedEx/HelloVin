using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloVin;
using HelloVin.Models;
using HelloVin.Interfaces;

namespace HelloVin.Tests.Models
{
    [TestClass]
    public class VinCheckerTest
    {
        [TestMethod]
        public void TestCheckVinLength()
        {
            // Arrange
            IVinChecker checker = new VinChecker(new List<IVinRule> 
                 { 
                     new VinLengthRule() 
                 } 
            );

            // Act
            var result = checker.Check("12345678901234567");

            // Assert
            Assert.AreEqual("Ok!!", result);
        }
    }
}
