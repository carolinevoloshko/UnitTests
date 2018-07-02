using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace MSTestTests
{
	[TestClass]
	public class TestPowMethod:TestBase
	{
	
		[TestMethod]
		public void TestPowWithPositive()
		{		
			//Act
			double result =Calculator.Pow(7,2);
			double expResult = 49;
            //Assert
            Assert.AreEqual(expResult, result, "Test failed:\n" + "Should be:  " + expResult + "\nBut was:  " + result);
        }

		[TestMethod]
		public void TestPowWithNegative()
        { 	
			//Act
			double result = Calculator.Pow(-1,4);
			double expResult = -1;
            //Assert
            Assert.AreEqual(expResult, result, "Test failed:\n" + "Should be:  " + expResult + "\nBut was:  " + result);

        }
	}
}
