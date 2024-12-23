using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using first_mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace first_mvc.Controllers
{
    public class HelloController : Controller
    {
        private readonly ILogger<HelloController> _logger;

        public HelloController(ILogger<HelloController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {   
            // _logger.LogInformation("Hello from the HelloController!");
            // return "Hello from the HelloController!";
            return View();
        }

        public string Salut(string nom, string prenom)
        {
            var login = new LoginViewModel{
                Email = nom,
                Password = prenom
            };
            return "Salut " + login.Email + " " + nom + "!";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}