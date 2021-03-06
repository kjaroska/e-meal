﻿using System.Collections.Generic;
using emeal.Models;
using emeal.Services.Interfaces;

namespace emeal.Controllers.Facades
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class IngredientFacade : BaseFacade
    {
        private readonly IRecipeFinder _recipesFinder;

        public IngredientFacade(IRecipeFinder finder, IBaseService baseService) : base(baseService)
        {
            _recipesFinder = finder;
        }

        internal IEnumerable<Recipe> SearchByProducts(List<int> queryArr, List<int>queryAllergies)
        {
            return _recipesFinder.GetQueryResult(queryArr, queryAllergies);
        }
    }
}