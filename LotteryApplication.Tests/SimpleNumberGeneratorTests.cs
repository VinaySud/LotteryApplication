using LotteryApplication.Logic.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using Moq;
using System.Collections.Generic;
using LotteryApplication.Logic.Enumerations;
using LotteryApplication.Logic.Models;

namespace LotteryApplication.Tests
{
    [TestClass]
    public class SimpleLotteryTicketTests
    {
        private readonly Mock<INumberGenerator> _numberGenerator;
        private readonly Mock<IColourPicker> _colourPicker;        

        public SimpleLotteryTicketTests()
        {
            _numberGenerator = new Mock<INumberGenerator>();
            _colourPicker = new Mock<IColourPicker>();

            _numberGenerator.Setup(x => x.Draw(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<List<int>>())).Returns(1);
            _colourPicker.Setup(x => x.Select(It.IsAny<int>())).Returns(Colour.Grey);
        }

        /// <summary>
        /// Ensure the generator returns exactly the numbers provided
        /// </summary>
        [DataTestMethod]
        [DataRow(5)]
        [DataRow(6)]
        public void SimpleLotteryTicket_Length_EqualsToValueRequested(int totalNumberToGenerate)
        {
            var lotterySettings = new LotterySettings { MinimumValue = 1, MaximumValue = 49, TotalNumbersToGenerate = totalNumberToGenerate };
            var simpleLotteryTicket = new SimpleLotteryTicket(_numberGenerator.Object, _colourPicker.Object);
            var randomNumbers = simpleLotteryTicket.Generate(lotterySettings);
     
            Assert.AreEqual(totalNumberToGenerate, randomNumbers.Count());
        }
    }
}