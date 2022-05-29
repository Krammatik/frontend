using Application_Layer.Common.Interfaces;
using Infrastructure_Layer.Common.Models.EndPoints;
using Infrastructure_Layer.Common.Models.Request.Authentication;
using Infrastructure_Layer.Services;
using Krammatik_Frontend.Models;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace Krammatik_Frontend.Controllers
{
    public class AccounttController : Controller
    {

        public IKrammatikService Client { get; set; }
        public AccounttController(IKrammatikService client)

        {
            Client = client;

        }

        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UserAuthentication(SignInModel modell)
        {
            //ToDo:
            // if(signin)
            // make request to Backend and do authentication test 
            // if (register)
            // creating a new user account 
            // Design ^^
            return RedirectToAction("index", "Home");
        }

    }
}
