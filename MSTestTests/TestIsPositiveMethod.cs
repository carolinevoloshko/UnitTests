using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;


namespace MSTestTests
{
	[TestClass]
	public class TestIsPositiveMethod:TestBase
	{
	
		[TestMethod]
		public void TestIsPositiveWithPositive()
		{
			//Act
			bool result = Calculator.isPositive(1);
			bool expResult = true;
            //Assert
            Assert.AreEqual(expResult, result, "Test failed:\n" + "Should be:  " + expResult + "\nBut was:  " + result);
        }
		[TestMethod]
		public void TestIsPostivieWithZero()
	    {
			//Act
			bool result = Calculator.isPositive(0);
			bool expResult = true;
            //Assert
            Assert.AreEqual(expResult, result, "Test failed:\n" + "Should be:  " + expResult + "\nBut was:  " + result);
        }
		[TestMethod]
		public void TestIsNegativeWithNegative()
		{	
			//Act
			bool result = Calculator.isPositive(-1);
			bool expResult = false;
            //Assert
            Assert.AreEqual(expResult, result, "Test failed:\n" + "Should be:  " + expResult + "\nBut was:  " + result);
        }
	
	}
}


