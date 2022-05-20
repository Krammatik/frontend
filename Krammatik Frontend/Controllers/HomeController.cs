using Application_Layer.Common.Interfaces;
using Krammatik_Frontend.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Krammatik_Frontend.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IKrammatikService _client;

        public HomeController(ILogger<HomeController> logger,IKrammatikService client)
        {
            _client = client;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                //TODO: Get actual user information
                var token =  await _client.AuthenticateByPasswordAsync("max.musterman", "MusterPassword123");
                // Set cookie for further use in later requests
                Response.Cookies.Append("token", token, new CookieOptions
                {
                    Expires = DateTimeOffset.Now.AddHours(8) // Expire after 8 hours
                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return View();
        }

        public IActionResult Privacy()
        {
            var tokenCookie = Request.Cookies["token"];
            if (tokenCookie != null)
            {
                Console.WriteLine(tokenCookie);
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}