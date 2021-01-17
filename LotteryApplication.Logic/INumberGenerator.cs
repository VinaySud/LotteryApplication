using System.Collections.Generic;

namespace LotteryApplication.Logic
{
    public interface INumberGenerator
    {
        List<int> Random(int totalUniqueNumbers);
    }
}
