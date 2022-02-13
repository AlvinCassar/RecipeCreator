using Application.Interfaces;
using Application.ViewModels;
using Domain.Interfaces;
using Domain.Models;

namespace Application.Services
{
    public class RecipeService : IRecipeService
    {

        private IRecipeRepository recipeRepository;

        public RecipeService(IRecipeRepository _recipeRepository)
        {
            recipeRepository = _recipeRepository;
        }

        public void AddRecipe(FullRecipeViewModel model) //if true save in file / if false save in database (saveOption)
        {
            recipeRepository.AddRecipe(new FullRecipe()
            {
                Id = model.Id,
                Title = model.Title,
                Instruction = model.Instruction
            });
        }
    }
}
