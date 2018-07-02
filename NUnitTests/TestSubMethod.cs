using NUnit.Framework;
using CSharpCalculator;

namespace NUnitTests
{
	[TestFixture]
    [Parallelizable]
    public class TestSubMethod : TestBase
	{
		[Test]

		[TestCase(10, 2, 8)]
		[TestCase(-1, -2, 1)]
		[TestCase(0, 2, -2)]
		public void TestSub(double a, double b, double expresult)
		{	
			//Act
			double result = Calculator.Sub(a, b);
			//Assert
			Assert.AreEqual(expresult, result,"Test failed:"+"Should be:" + expresult +"But was"+result);
		}
	}
}
