using System.Collections.Generic;
using DrinkWorld.Data.Interfaces;
using DrinkWorld.Data.Models;

namespace DrinkWorld.Data.mocks
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories => new List<Category>
        {
            new Category {CategoryName = "Alcoholic",Description = "All alcoholic drinks"},
            new Category {CategoryName = "Non-alcoholic",Description = "All non-alcoholic drinks"}
        };
    }
}
