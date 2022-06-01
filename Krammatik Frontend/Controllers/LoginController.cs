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
                //TODO: Get actual user information
               string  token = await Client.AuthenticateByPasswordAsync(modell.Username, modell.Password);

                // Set cookie for further use in later requests
                Response.Cookies.Append("token", token, new CookieOptions
                {
                    Expires = DateTimeOffset.Now.AddHours(8) // Expire after 8 hours
                });

                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return View("Login");
            }
            
                return RedirectToAction("index", "Home");
        }

    }
}
