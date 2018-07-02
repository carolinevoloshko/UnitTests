using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace MSTestTests
{
    [TestClass]
    public class TestAbsMethod : TestBase
    {

        [TestMethod]     
        public void TestAbsWithNegative()
        {
       
            //Act
            double result = Calculator.Abs(-1);
            double expResult = 1;
            //
            //Assert
            Assert.AreEqual(expResult, result, "Test failed:\n" + "Should be:  " + expResult + "\nBut was:  " + result);
        }

        [TestMethod]
        public void TestAbsWithNull()
        {
            //Act
            double result = Calculator.Abs(null);
            double expResult = 0;
            //Assert
            Assert.AreEqual(expResult, result, "Test failed:\n" + "Should be:  " + expResult + "\nBut was:  " + result);


        }
    }
}
