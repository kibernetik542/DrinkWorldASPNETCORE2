using System.Collections.Generic;
using DrinkWorld.Data.Models;

namespace DrinkWorld.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Drink> PreferredDrinks { get; set; }
    }
}
