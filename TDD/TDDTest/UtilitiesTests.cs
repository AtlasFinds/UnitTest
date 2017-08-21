using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD;

namespace TDDTest
{
    [TestClass]
    public class UtilitiesTests
    {
        [TestMethod]
        public void ShouldFindOneInMysterious()
        {
            // Arrange
            var stringToCheck = "mysterious";
            var stringToFind = "s";
            var expectedResult = 1;
            Utilities utilities = new Utilities();
            
            // Act 
            var actualResult = utilities.CountOccurences(stringToCheck, stringToFind);

            // Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Add()
        {
            // Arrange 
            var a = 5;
            var b = 5;
            var expected = 10;
            Utilities utilities = new Utilities();

            // Act 
            var result = utilities.Add(a, b);

            // Assert 
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void HellowWorld()
        {
            // Arrange 
            var expected = "Hellow World!";
            Utilities utilities = new Utilities();

            // Act 
            var result = utilities.HellowWorld();

            // Assert 
            Assert.AreEqual(expected, result);
        }
    }
}
