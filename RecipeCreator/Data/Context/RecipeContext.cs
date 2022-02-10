using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Domain.Models;

namespace Data.Context
{
    public class RecipeContext : IdentityDbContext
    {
        public RecipeContext(DbContextOptions<RecipeContext> options)
            : base(options)
        { }

        public DbSet<FullRecipe> FullRecipe { get; set; }
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseLazyLoadingProxies();
        }*/
    }
}
