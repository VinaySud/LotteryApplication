using LotteryApplication.Logic.Models;
using System.Collections.Generic;

namespace LotteryApplication.Logic.Services
{
    public interface ILotteryTicket
    {
        IEnumerable<LotteryNumber> Generate(LotterySettings settings);
    }
}