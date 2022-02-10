using Application.ViewModels;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IRecipeService
    {
        public void AddRecipe(FullRecipeViewModel model);
       
    }
}
