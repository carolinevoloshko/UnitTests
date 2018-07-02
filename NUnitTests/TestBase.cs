using NUnit.Framework;
using System;
using CSharpCalculator;
namespace NUnitTests
{
	public class TestBase
	{
        public Calculator Calculator;

		[SetUp]
		public void Init()
		{
            Calculator = new Calculator();
            Console.WriteLine("Base Initialize");
            
        }

		[TearDown]
		public void CleanUp()
		{
			Console.WriteLine("BaseCleanUp");
		}
	}
}
