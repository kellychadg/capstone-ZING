﻿using Capstone.Web.Models;
using Capstone.Web.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Web.DAL
{
   public interface IRecipeIngredientDAL
    {
        List<RecipeIngredient> GetRecipeIngredients(int recipeId);
       
    }
}