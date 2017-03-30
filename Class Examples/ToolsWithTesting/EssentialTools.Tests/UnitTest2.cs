using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTools.Models;

namespace EssentialTools.Tests{
    [TestClass]
    public class UnitTest2
    {
        private ITaxCalculator getTestObject()
        {
            return new CurrentTaxCalculator();
        }
        [TestMethod]
        public void Tax_Bracket_One()
        {
            // arrange

            ITaxCalculator target = getTestObject();
            decimal total = 11300M;

            // act
            decimal taxBack = target.FindTaxAmount(total);


            // assert
            Assert.AreEqual(95M, taxBack);


        }
        [TestMethod]
        public void Tax_Bracket_Two()
        {
            // arrange

            ITaxCalculator target = getTestObject();
            decimal total = 30350M;

            // act
            decimal taxBack = target.FindTaxAmount(total);


            // assert
            Assert.AreEqual(2536.25M, taxBack);

        }
    }
}
