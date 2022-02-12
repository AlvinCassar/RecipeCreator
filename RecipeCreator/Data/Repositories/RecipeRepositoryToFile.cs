using Domain.Interfaces;
using Domain.Models;
using System.IO;
using System.Collections.Generic;
using System.Text;
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

            File.AppendAllText(fullPath, "Recipe Instruction:" + r.Title +"\t - \t" + r.Instruction + "\n");
            Debug.WriteLine("Added to File");
        }
    }
}
