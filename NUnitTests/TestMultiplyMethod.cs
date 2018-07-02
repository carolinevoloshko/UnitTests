using CSharpCalculator;
using NUnit.Framework;



namespace NUnitTests
{
    [TestFixture]
    [Parallelizable]
    public class TestMultiplyMethod : TestBase
    {
        [Test]

        [TestCase(1.3, 2.5, 3.25)]
        [TestCase(1, 2, 2)]
        [TestCase(-1, 2, -2)]
        [TestCase(0, 2, 0)]
        [TestCase(0, -1, 0)]

        public void TestMultiply(double a, double b, double expresult)
        {
            //Act
            double result = Calculator.Multiply(a, b);
            //Assert
            Assert.AreEqual(expresult, result, "Test failed:" + "Should be:" + expresult + "But was" + result);

        }
    }
}

