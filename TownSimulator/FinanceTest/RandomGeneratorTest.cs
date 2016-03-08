using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TownSimulatorEngine;

namespace FinanceTest
{
    [TestClass]
    public class RandomGeneratorTest
    {
        [TestMethod]
        public void RandomGeneratorTestMethod()
        {
            RandomGenerator random = new RandomGenerator();

            int number1;
            number1 = (int) random.GenerateRandomNumber(10, 0);

            Assert.AreEqual(number1, number1);
        }
    }
}
