using NUnit.Framework;
using CSharpCalculator;

namespace NUnitTests
{
		[TestFixture]
        [Parallelizable]
    public class TestSinMethod : TestBase
		{
			[Test]
		
			[TestCase(0,0)]
			[TestCase(1, 0.8414709848078965d)]
			[TestCase(-1,-0.8414709848078965)]
		    [TestCase(1.5,0.99749498660405445)]
		public void TestSin(double a, double expresult)
 		{
				//Act
				double result =Calculator.Sin(a);
            //Assert
            Assert.AreEqual(expresult, result, "Test failed:" + "Should be:" + expresult + "But was" + result);
        }
		}
	}

