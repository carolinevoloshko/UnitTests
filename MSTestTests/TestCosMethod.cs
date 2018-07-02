using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace MSTestTests
{
	[TestClass]
	public class TestCosMethod:TestBase
	{
	   [TestMethod]
		public void TestCosWithZero()
		{		
			//Act
			double result = Calculator.Cos(0);
			double expResult = 1;
            //Assert
            Assert.AreEqual(expResult, result, "Test failed:\n" + "Should be:  " + expResult + "\nBut was:  " + result);
        }

		[TestMethod]
		public void TestCosWithPositiveDigit()
		{			
			//Act
			double result = Calculator.Cos(1);
			double expResult = 0.5403023058681398;
            //Assert
            Assert.AreEqual(expResult, result, "Test failed:\n" + "Should be:  " + expResult + "\nBut was:  " + result);
        }
	

	}
}
