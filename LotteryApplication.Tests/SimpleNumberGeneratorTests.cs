using LotteryApplication.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace LotteryApplication.Tests
{
    /// <summary>
    /// Simple unit test to ensure the random numbers returned is matching to exactly six numbers
    /// </summary>
    [TestClass]
    public class SimpleNumberGeneratorTests
    {
        /// <summary>
        /// Ensure the generator returns exactly 6 numbers
        /// </summary>
        [TestMethod]
        public void SimpleNumberGenerator_Length_EqualsToSix()
        {
            var numberGenerator = new SimpleNumberGenerator();
            var randomNumbers = numberGenerator.Random(6);

            Assert.AreEqual(6, randomNumbers.Count);
        }

        /// <summary>
        /// Ensure that all 49 numbers generated are unique
        /// </summary>
        [TestMethod]        
        public void SimpleNumberGenerator_UniqueNumbers_Success()
        {
            var numberGenerator = new SimpleNumberGenerator();
            var randomNumbers = numberGenerator.Random(49);

            Assert.AreEqual(randomNumbers.Distinct().Count(), randomNumbers.Count());
        }

        /// <summary>
        /// Ensure we have an error when maximum number is exceeded
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void SimpleNumberGenerator_ExceedMaximum_Failed()
        {
            var numberGenerator = new SimpleNumberGenerator();
            numberGenerator.Random(50);
        }
    }
}