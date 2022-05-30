using Application_Layer.Common.Interfaces;
using Infrastructure_Layer.Common.Models.EndPoints;
using Infrastructure_Layer.Common.Models.Request.Authentication;
using Infrastructure_Layer.Services;
using Krammatik_Frontend.Models;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace Krammatik_Frontend.Controllers
{
    public class LoginController : Controller
    {

        public IKrammatikService Client { get; set; }
        public LoginController(IKrammatikService client)

        {
            Client = client;

        }

        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UserAuthentication(SignInModel modell)
        {
          try
            { 
                 string  test = await Client.AuthenticateByPasswordAsync(modell.Username, modell.Password);
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return RedirectToAction("index", "Home");
        }

    }
}
