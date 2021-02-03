using LotteryApplication.Logic.Models;
using System.Collections.Generic;
using System.Linq;

namespace LotteryApplication.Logic.Services
{
    public class SimpleLotteryTicket : ILotteryTicket
    {
        private readonly INumberGenerator _numberGenerator;
        private readonly IColourPicker _colourPicker;

        public SimpleLotteryTicket(INumberGenerator numberGenerator, IColourPicker colourPicker)
        {
            _numberGenerator = numberGenerator;
            _colourPicker = colourPicker;
        }

        /// <summary>
        /// Method to return a collection of unique and random numbers between 1 - 49
        /// </summary>
        /// <param name="settings"></param>
        /// <returns></returns>
        public IEnumerable<LotteryNumber> Generate(LotterySettings settings)
        {
            // Setup local variables
            var randomNumberList = new List<LotteryNumber>();

            // Loop until we have a collection of unique random numbers added to a list
            for (int count = 0; count < settings.TotalNumbersToGenerate; count++)
            {
                var randomUniqueNumber = _numberGenerator.Draw(settings.MinimumValue, settings.MaximumValue, randomNumberList.Select(x => x.Number).ToList());

                randomNumberList.Add(new LotteryNumber
                {
                    Number = randomUniqueNumber,
                    Colour = _colourPicker.Select(randomUniqueNumber)
                });
            }

            // Sort the numbers in numerical order and return the result
            return randomNumberList.OrderBy(x => x.Number);
        }
    }
}