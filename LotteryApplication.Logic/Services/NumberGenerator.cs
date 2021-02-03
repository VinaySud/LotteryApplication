using System;
using System.Collections.Generic;
using System.Linq;

namespace LotteryApplication.Logic.Services
{
    public class NumberGenerator : INumberGenerator
    {
        public int Draw(int min, int max, List<int> listOfNum)
        {            
            var rnd = new Random();
            return Enumerable.Range(min, max).Where(i => !listOfNum.Contains(i)).OrderBy(x => rnd.Next()).FirstOrDefault();         
        }
    }
}