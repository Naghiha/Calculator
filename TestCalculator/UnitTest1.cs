using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace TestCalculator
{
    [TestClass]
    public class TestCalcualtor
    {
        [TestMethod]
        public void SumOfEvenTerms_Calc()
        {
            //preparation
            Service.Calculator calc = new Service.Calculator();
            int[] exampleFib = new int[10] { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 };

            var rangeTest1 = 22;
            var rangeTest2 = 90;
            var boudaryRange = 4000000;
            //logic

            var expectedrangeTest1Resualt = calc.SumOfEvenTerms(rangeTest1);
            var expectedrangeTest2Resualt = calc.SumOfEvenTerms(rangeTest2);
            var expectedboudaryRangeResualt = calc.SumOfEvenTerms(boudaryRange);

            var actualRangeTest1Resualt = exampleFib.Where(x => x < rangeTest1 && (x % 2 == 0)).Sum(x => x);
            var actualRangeTest2Resualt = exampleFib.Where(x => x < rangeTest2 && (x % 2 == 0)).Sum(x => x);
            var actualboudaryRangeResualt = 4613732; // pre calc
            //assert
            Assert.AreEqual(expectedrangeTest1Resualt, actualRangeTest1Resualt);
            Assert.AreEqual(expectedrangeTest2Resualt, actualRangeTest2Resualt);
            Assert.AreEqual(expectedboudaryRangeResualt, actualboudaryRangeResualt);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SumOfEvenTerms_OutOfRange()
        {
            //Preparation
            var calc = new Service.Calculator();


            //Logic
            int outOfRangeValue1 = 4000001;
            int outOfRangeValue2 = 5000000;


            //assert
            var assert1 = calc.SumOfEvenTerms(outOfRangeValue1);
            var assert2 = calc.SumOfEvenTerms(outOfRangeValue2);
        }
    }
}
