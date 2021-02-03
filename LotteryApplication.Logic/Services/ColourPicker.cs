using LotteryApplication.Logic.Enumerations;
using System;

namespace LotteryApplication.Logic.Services
{
    public class ColourPicker : IColourPicker
    {
        public Colour Select(int number)
        {
            var roundedValue = (int)Math.Floor(number / 10.0) * 10;
            return (Colour)roundedValue;
        }
    }
}