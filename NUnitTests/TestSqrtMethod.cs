using NUnit.Framework;
using CSharpCalculator;

namespace NUnitTests
{
	[TestFixture]
    [Parallelizable]
    public class TestSqrtMethod: TestBase
	{
		[Test]

		[TestCase(9,3)]
		[TestCase(0,0)]
		[TestCase(-0,-0)]
		public void TestSqrt(double a, double expresult)
		{     
            //Act
			double result = Calculator.Sqrt(a);
            //Assert
            Assert.AreEqual(expresult, result, "Test failed:" + "Should be:" + expresult + "But was" + result);
        }
	}
}
