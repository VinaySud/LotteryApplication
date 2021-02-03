using System.Collections.Generic;

namespace LotteryApplication.Logic.Services
{
    public interface INumberGenerator
    {
        int Draw(int min, int max, List<int> listOfNum);
    }
}