using LotteryApplication.Logic.Enumerations;

namespace LotteryApplication.Logic.Services
{
    public interface IColourPicker
    {
        Colour Select(int number);
    }
}
