using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDTest;

namespace TDDTestUnit
{
    [TestClass]
    public class CalTest
    {
       public  Calculator cal = new Calculator();

      
        public void InitMethod()
        {

　　    Console.WriteLine("Initialization method");

　　    }

        [TestMethod]
        public void TestAdd()
        {
            int expecAdd = 100;
            int resAdd = cal.Add(30, 70);
            Assert.AreEqual(expecAdd, resAdd);
        }
       

        [TestMethod]
        public void TestDelete()
        {

            int expecDelete = 15;
            int resDelete = cal.Minus(45, 30);
            Assert.AreEqual(expecDelete, resDelete);

        

        }

        [TestMethod]
        public void TestDivide()
        {

            int expecDivide = 5;
            int resDivide = cal.Divide(10, 2);
            Assert.AreEqual(expecDivide, resDivide);

        }

        [TestMethod]
        public void TestMultiply()
        {
            int expecMultiply = 20;
            int resMultiply = cal.Multiply(10, 2);
            Assert.AreEqual(expecMultiply, resMultiply);
        }

    }
}
