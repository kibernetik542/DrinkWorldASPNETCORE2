using System.Collections.Generic;
using System.Linq;
using DrinkWorld.Data.Interfaces;
using DrinkWorld.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DrinkWorld.Data.Repositories
{
    public class DrinkRepository : IDrinkRepository
    {
        private readonly AppDbContext _appDbContext;

        public DrinkRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Drink> Drinks => _appDbContext.Drinks.Include(c => c.Category);

        public IEnumerable<Drink> PrefferedDrinks => _appDbContext.Drinks.Where(p => p.IsPrefferedDrink)
            .Include(c => c.Category);

        public Drink GetDrinkById(int drinkId) => 
            _appDbContext.Drinks.FirstOrDefault(P => P.DrinkId == drinkId);

    }
}
