using Data.Context;
using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public class RecipeRepository : IRecipeRepository
    {
        private RecipeContext context;
        public RecipeRepository(RecipeContext _context)
        {
            context = _context;
        }

        public void AddRecipe(FullRecipe r)
        {
            context.FullRecipe.Add(r);
            context.SaveChanges();
        }
    }
}
