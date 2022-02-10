using Application.Interfaces;
using Application.ViewModels;
using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    public class RecipeService : IRecipeService
    {

        private IRecipeRepository recipeRepository;

        public RecipeService(IRecipeRepository _recipeRepository)
        {
            recipeRepository = _recipeRepository;
        }

        public void AddRecipe(FullRecipeViewModel model)
        {
            recipeRepository.AddRecipe(new Domain.Models.FullRecipe()
            {
                Id = model.Id,
                Title = model.Title,
                Instruction = model.Instruction
            });
            
        }

    }
}
