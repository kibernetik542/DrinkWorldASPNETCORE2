using System.Collections.Generic;
using DrinkWorld.Data.Models;

namespace DrinkWorld.Data.Interfaces
{
    public interface IDrinkRepository
    {
        IEnumerable<Drink> Drinks { get; }
        IEnumerable<Drink> PrefferedDrinks { get; }
        Drink GetDrinkById(int drinkId);
    }
}
