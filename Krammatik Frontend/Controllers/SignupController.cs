using Application_Layer.Common.Interfaces;
using Krammatik_Frontend.Models;
using Microsoft.AspNetCore.Mvc;

namespace Krammatik_Frontend.Controllers
{
    public class SignupController : Controller
    {
        public IKrammatikService Client { get; set; }
        public SignupController(IKrammatikService client)

        {
            Client = client;

        }

        public IActionResult Signup()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignupMethod(SignInModel modell)
        {
            try
            {
                string test = await Client.SignupAsync(modell.Username, modell.Password);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return RedirectToAction("index", "Home");
        }

    }
}
