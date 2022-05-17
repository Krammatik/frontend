using Application_Layer.Common.Interfaces;
using Krammatik_Frontend.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Krammatik_Frontend.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGrammatikService _client;

        public HomeController(ILogger<HomeController> logger,IGrammatikService client)
        {
            _client = client;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            await _client.AuthenticateByPasswordAsync();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}