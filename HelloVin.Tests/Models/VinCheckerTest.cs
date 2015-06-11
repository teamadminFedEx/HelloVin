using System.Collections.Generic;
using HelloVin.Interfaces;
using HelloVin.Models;
using HelloVin.Models.DataContract;
using NUnit.Framework;

namespace HelloVin.Tests.Models
{
    [TestFixture]
    public class VinCheckerTest
    {
        [Test]
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
            Assert.AreEqual(CheckResult.Ok, result.CheckResult);
        }
    }
}
