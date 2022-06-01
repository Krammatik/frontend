using Microsoft.AspNetCore.Mvc;

namespace Krammatik_Frontend.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
