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

        public void AddRecipe(FullRecipe recipe)
        {
            recipeRepository.AddRecipe(new Domain.Models.FullRecipe()
            {
                Id = recipe.Id,
                Title = recipe.Title,
                Instruction = recipe.Instruction
            });
            
        }

    }
}
