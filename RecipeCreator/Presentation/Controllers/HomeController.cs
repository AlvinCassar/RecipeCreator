using Application.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Presentation.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

       /* [HttpPost]
        public IActionResult AddRecipe(FullRecipeViewModel model)
        {
            if (string.IsNullOrEmpty(model.Title) || string.IsNullOrEmpty(model.Instruction))
            {
                //ViewBag.Error = "Should not be left Empty";
                Debug.WriteLine("Empty field");

            }
            else
            {
                Debug.WriteLine("Not Empty");
            }

            return View();
        }*/


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
