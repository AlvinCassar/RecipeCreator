using Domain.Interfaces;
using Domain.Models;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;

namespace Data.Repositories
{
    public class RecipeRepositoryToFile : IRecipeRepository
    {
        public void AddRecipe(FullRecipe r)
        {
            var fullPath = Path.GetFullPath(@"mydir");
            fullPath += "\\recipes";

            if (!Directory.Exists(fullPath))
                Directory.CreateDirectory(fullPath);

            fullPath += "\\recipe.txt";

            File.AppendAllText(fullPath, "\n\nRecipe Title:" + r.Title +"\n"); //put title at the top in the textfile.

            string[] stepbystep = r.Instruction.Split("\n");

            int counter = 0;

            foreach (string step in stepbystep)
            {
                File.AppendAllText(fullPath, "Step " + ++counter + ": " + step);
            }

            Debug.WriteLine("Added to File");
        }
    }
}
