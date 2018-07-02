using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace MSTestTests
{
	[TestClass]
	public class TestDivideMethod:TestBase
	{
		
		[TestMethod]
		public void TestDivideWithPositive()
		{
			//Act
			double result = Calculator.Divide(3, 1);
			double expResult = 3;
            //Assert
            Assert.AreEqual(expResult, result, "Test failed:\n" + "Should be:  " + expResult + "\nBut was:  " + result);
        }
		[TestMethod]
		public void TestDivideWithNegative()
		{
			//Act
			double result = Calculator.Divide(-1, 1);
			double expResult = -1;
            //Assert
            Assert.AreEqual(expResult, result, "Test failed:\n" + "Should be:  " + expResult + "\nBut was:  " + result);
        }
        public void TestDivideWithInt()
        {
            //Act
            int a = 5;
            int b = 1;
            double result = Calculator.Divide(a, b);
            double expResult = 5;           
            //Assert
            Assert.AreEqual(expResult, result, "Test failed:\n" + "Should be:  " + expResult + "\nBut was:  " + result);
        }

        [TestMethod]
		public void TestDivideWithZero()
		{
            //Act
            double a = 2;
            double b = 0;
			double result = Calculator.Divide(a, b);
            double expResult = a / b;
            //Assert
            Assert.AreEqual(expResult, result, "Test failed:\n" + "Should be:  " + expResult + "\nBut was:  " + result);
        }
	}
}
