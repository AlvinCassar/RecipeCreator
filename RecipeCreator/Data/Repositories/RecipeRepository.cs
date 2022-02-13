using Data.Context;
using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public class RecipeRepository : IRecipeRepository //THIS IS TO SAVE TO DATABASE 
    {
        private RecipeContext context;
        public RecipeRepository(RecipeContext _context)
        {
            context = _context;
        }

        public void AddRecipe(FullRecipe r)//if options was to save in database data will be changed to be suitable for a database row.
        {
            string[] stepbystep = r.Instruction.Split("\n");

            string ogTitle = r.Title;
            int counter = 0;

            foreach (string step in stepbystep)
            {
                r.Title = ogTitle + " - V" + ++counter;
                r.Instruction = step;
                context.FullRecipe.Add(r);
                context.SaveChanges();
                r.Id = 0; //reset the id back to 0 so the program sets it to the next id automatically.
            }
        }
    }
}

   

    