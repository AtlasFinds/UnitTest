using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD;

namespace TDDTest
{
    [TestClass]
    public class BobUnitTest
    {
       
        [TestMethod]
        public void Test_GetValue()
        {
            // Arrange 
            const string param = "bobby";
            const int expectedValue = 1;
            Bob bob = new Bob();

            // Act 
            var result = bob.GetValue(param);

            // Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void Test_StubDependency()
        {
            // Arrange 
            const string param1 = "abcd";
            const string param2 = "xyz";
            const int expectedResultOne = 1;
            const int expectedResultTwo = 2; 
            Bob bob = new Bob();   

            // Act 
            var result1 = bob.StubDependency(param1);
            var result2 = bob.StubDependency(param2);

            // Assert
            Assert.AreEqual(expectedResultOne, result1);
            Assert.AreEqual(expectedResultTwo, result2);
        }

    }
}
