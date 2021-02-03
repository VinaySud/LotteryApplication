using LotteryApplication.Logic.Models;

namespace LotteryApplication.Logic.Services
{
    public class LotterySettingService : ISettingService<LotterySettings>
    {
        /// <summary>
        /// In an ideal world, this could be coming from a data store
        /// </summary>
        /// <returns></returns>
        public LotterySettings Get()
            => new LotterySettings { MinimumValue = 1, MaximumValue = 49, TotalNumbersToGenerate = 6 };
    }
}