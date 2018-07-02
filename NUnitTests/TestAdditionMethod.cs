using CSharpCalculator;
using NUnit.Framework;

namespace NUnitTests
{
	[TestFixture]
    [Parallelizable]
    public class TestAdditionMethod:TestBase
	{
		[Test]

		[TestCase(1.3, 2.5,3.8)]
		[TestCase(1,2,3)]
		[TestCase(-1, -2, -3)]
		[TestCase(-1, 2, 1)]
		public void TestAddition(double a,double b,double expresult)
		{ 
			//Act
			double result = Calculator.Add(a,b);
            //Assert
            Assert.AreEqual(expresult, result, "Test failed:\n" + "Should be:  " + expresult + "But was:  " + result);
        }
	}
} 
