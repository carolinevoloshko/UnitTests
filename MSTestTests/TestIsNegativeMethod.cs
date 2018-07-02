using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace MSTestTests
{
	[TestClass]
	public class TestIsNegativeMethod:TestBase
	{
	   [TestMethod]
	   
		public void TestIsNegativeWithPositive()
		{		
			//Act
			bool result = Calculator.isNegative(2);
			bool expResult = false;
            //
            //Assert
            Assert.AreEqual(expResult, result, "Test failed:\n" + "Should be:  " + expResult + "\nBut was:  " + result);
        }
		[TestMethod]
		public void TestIsNegativeWithZero()
		{
			
			//Act
			bool result = Calculator.isNegative(0);
			bool expResult = false;
            //
            //Assert
            Assert.AreEqual(expResult, result, "Test failed:\n" + "Should be:  " + expResult + "\nBut was:  " + result);
        }
		[TestMethod]
		public void TestIsNegativeWithNegative()
		{
		
			//Act
			bool result = Calculator.isNegative(-1);
		    bool expResult = true;
            //
            //Assert
            Assert.AreEqual(expResult, result, "Test failed:\n" + "Should be:  " + expResult + "\nBut was:  " + result);
        }
        [TestMethod]
        public void TestNegativeWithInt()
        {
            //Act
            int a = -5;
            
           bool result = Calculator.isNegative(a);
            bool expResult = true;
            //Assert
            Assert.AreEqual(expResult, result, "Test failed:\n" + "Should be:  " + expResult + "\nBut was:  " + result);
        }
        [TestMethod]
        public void TestNegativeWithString()
        {
            //Act
            string a = "-5";

            bool result = Calculator.isNegative(a);
            bool expResult = true;
            //Assert
            Assert.AreEqual(expResult, result, "Test failed:\n" + "Should be:  " + expResult + "\nBut was:  " + result);
        }


    }
}
