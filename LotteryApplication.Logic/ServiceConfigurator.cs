using LotteryApplication.Logic.Models;
using LotteryApplication.Logic.Services;
using Microsoft.Extensions.DependencyInjection;

namespace LotteryApplication.Logic
{
    public static class ServiceConfigurator
    {
        public static void AddLotteryServices(this IServiceCollection services)
        {
            services.AddTransient<ISettingService<LotterySettings>, LotterySettingService>();
            services.AddTransient<ILotteryTicket, SimpleLotteryTicket>();
            services.AddTransient<INumberGenerator, NumberGenerator>();
            services.AddTransient<IColourPicker, ColourPicker>();
        }
    }
}