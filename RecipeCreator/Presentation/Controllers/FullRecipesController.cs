using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Data.Context;
using Domain.Models;
using Application.ViewModels;
using System.Diagnostics;
using Application.Interfaces;
using Microsoft.AspNetCore.Hosting;

namespace Presentation.Controllers
{
    public class FullRecipesController : Controller
    {
       /* private IRecipeService recipeService;
        private IWebHostEnvironment webHostEnvironment;

        public FullRecipesController(IRecipeService _recipeService, IWebHostEnvironment _webHostEnvironment)
        {
            webHostEnvironment = _webHostEnvironment;
            recipeService = _recipeService;
        }
*/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(FullRecipeViewModel model)
        {
            if (string.IsNullOrEmpty(model.Title) || string.IsNullOrEmpty(model.Instruction))
            {
                ViewBag.Error = "Should not be left empty";
                Debug.WriteLine("Fields Cannot be left Empty");
                return View();
            }

            Debug.WriteLine("Both Title and Instructions Filled :)");
            Debug.WriteLine("Title: "+ model.Title);
            Debug.WriteLine("Instru: "+ model.Instruction);

            //Now split the instructions where the is /n and put in list. Than check count of list so you know how many steps (or in for each)
            //than 1st step is Title + v1
            //2nd step is title + v2 and so on.
            //stop adding steps when amount of steps finish.

            return RedirectToAction("Index");
        }
    }
}
