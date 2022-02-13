using Microsoft.AspNetCore.Mvc;
using Application.ViewModels;
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
                ViewBag.Error = "Should not be left empty";
                return View();
            }
            else
            {
                recipeService.AddRecipe(model);
            }

            return RedirectToAction("Index");
        }
    }
}
