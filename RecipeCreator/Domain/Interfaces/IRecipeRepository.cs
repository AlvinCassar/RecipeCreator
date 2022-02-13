using Domain.Models;

namespace Domain.Interfaces
{
    public interface IRecipeRepository
    {
        public void AddRecipe(FullRecipe r);
    }
}
