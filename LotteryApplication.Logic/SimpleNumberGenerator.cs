using System;
using System.Collections.Generic;

namespace LotteryApplication.Logic
{
    public class SimpleNumberGenerator : INumberGenerator
    {
        /// <summary>
        /// Method to return a collection of unique and random numbers between 1 - 49
        /// </summary>
        /// <param name="totalUniqueNumbers">Total number of unique random integers to return</param>
        /// <returns></returns>
        public List<int> Random(int totalUniqueNumbers)
        {            
            // Setup local variables
            var random = new Random();
            var randomNumberList = new List<int>();
            int maxUpperBoundNumber = 50;

            // Before we start, ensure we don't ask for more numbers than actually possible
            if (totalUniqueNumbers >= maxUpperBoundNumber)
                throw new Exception($"Total unique numbers should not be equal or exceed the maximum upper bound limit of {maxUpperBoundNumber}");

            // Loop until we have a collection of unique random numbers added to a list
            for (int count = 0; count < totalUniqueNumbers; count++)
            {
                int randomNumber;
                bool numberExists;

                do
                {
                    randomNumber = random.Next(1, maxUpperBoundNumber);
                    numberExists = randomNumberList.IndexOf(randomNumber) != -1;
                }
                while (numberExists);

                randomNumberList.Add(randomNumber);
            }

            // Sort the numbers in numerical order
            randomNumberList.Sort();

            // Return the result
            return randomNumberList;
        }        
    }
}
