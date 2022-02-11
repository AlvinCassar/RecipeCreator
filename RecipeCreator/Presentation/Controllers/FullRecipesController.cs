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
        private IRecipeService recipeService;
        private IWebHostEnvironment webHostEnvironment;

        public FullRecipesController(IRecipeService _recipeService, IWebHostEnvironment _webHostEnvironment)
        {
            webHostEnvironment = _webHostEnvironment;
            recipeService = _recipeService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(FullRecipeViewModel model)
        {
            if (string.IsNullOrEmpty(model.Title) || string.IsNullOrEmpty(model.Instruction))
            {
                //this is used only 
                ViewBag.Error = "Should not be left empty";
                return View();
            }

            string[] stepbystep = model.Instruction.Split("\n");

            string ogTitle = model.Title;
            int counter = 0;

            foreach (string step in stepbystep)
            {
                model.Title = ogTitle + " - V" + ++counter;
                model.Instruction = step;
                recipeService.AddRecipe(model);
            }

            return RedirectToAction("Index");
        }
    }
}
