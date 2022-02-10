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

namespace Presentation.Controllers
{
    public class FullRecipesController : Controller
    {
        private readonly RecipeContext _context;

        public FullRecipesController(RecipeContext context)
        {
            _context = context;
        }


        // GET: FullRecipes/Create
        public IActionResult Create(FullRecipeViewModel model)
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
        }

        // POST: FullRecipes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Instruction")] FullRecipe fullRecipe)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fullRecipe);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fullRecipe);
        }

        private bool FullRecipeExists(int id)
        {
            return _context.FullRecipe.Any(e => e.Id == id);
        }
    }
}
