using LotteryApplication.Logic;
using LotteryApplication.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace LotteryApplication.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IOptions<LotterySettings> _lotterSettings;
        private readonly INumberGenerator _numberGenerator;

        public HomeController(ILogger<HomeController> logger, IOptions<LotterySettings> lotterySettings, INumberGenerator numberGenerator)
        {
            _logger = logger;
            _lotterSettings = lotterySettings;
            _numberGenerator = numberGenerator;
        }

        public IActionResult Index()
        {
            var randomNumbers = _numberGenerator.Random(_lotterSettings.Value.TotalNumbersToGenerate);

            // TODO: Handle exceptions

            return View(randomNumbers);
        }
    }
}