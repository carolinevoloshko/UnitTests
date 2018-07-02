using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace MSTestTests
{
   public  class TestBase
    {
        public Calculator Calculator;
        
        [TestInitialize]
        public void Start()
        {
            Calculator  = new Calculator();
            Console.Out.WriteLine("Start Test");

        }

        [TestCleanup]
        public void CleanUp()
        {
            Console.Out.WriteLine("Test is finished");
        }
    }
}
