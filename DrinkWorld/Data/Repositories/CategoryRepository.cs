using System.Collections.Generic;
using DrinkWorld.Data.Interfaces;
using DrinkWorld.Data.Models;

namespace DrinkWorld.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        public IEnumerable<Category> Categories => _appDbContext.Categories;
    }
}
