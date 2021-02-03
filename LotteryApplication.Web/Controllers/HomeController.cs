using LotteryApplication.Logic.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LotteryApplication.Logic.Services;

namespace LotteryApplication.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ILotteryTicket _lotteryTicket;
        private readonly ISettingService<LotterySettings> _settingService;

        public HomeController(ILogger<HomeController> logger, ILotteryTicket lotteryTicket, ISettingService<LotterySettings> settingService)
        {
            _logger = logger;
            _lotteryTicket = lotteryTicket;
            _settingService = settingService;
        }

        public IActionResult Index()
        {
            var settings = _settingService.Get();
            var randomNumbers = _lotteryTicket.Generate(settings);

            return View(randomNumbers);
        }
    }
}