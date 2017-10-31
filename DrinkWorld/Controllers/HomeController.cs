using DrinkWorld.Data.Interfaces;
using DrinkWorld.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DrinkWorld.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDrinkRepository _drinkRepository;

        public HomeController(IDrinkRepository drinkRepository)
        {
            _drinkRepository = drinkRepository;
        }

        public ViewResult Index()
        {
            var hvm = new HomeViewModel
            {
                PreferredDrinks = _drinkRepository.PrefferedDrinks
            };
            return View(hvm);
        }
    }
}
