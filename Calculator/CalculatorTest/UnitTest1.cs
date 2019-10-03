using System;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTest
    {
    [TestClass]
    public class UnitTest1
        {
         
            [TestMethod]
            public void TestAdd()
                {
                Assert.AreEqual(3, Program.Add(1, 2));
                }

            [TestMethod]
            public void TestSubtract()
                {
                Assert.AreEqual(6, Program.Subtract(8, 2));
                }

            [TestMethod]
            public void TestDivide1()
                {
                Assert.AreEqual(4, Program.Divide(8, 2));
                }

            [TestMethod]
            public void TestDivide2()
                {
                Assert.AreEqual(2.67, Math.Round(Program.Divide(8, 3), 2));
                }

            [TestMethod]
            public void TestMultiply()
                {
                Assert.AreEqual(8, Program.Multiply(4, 2));
                }
            
        }
     }