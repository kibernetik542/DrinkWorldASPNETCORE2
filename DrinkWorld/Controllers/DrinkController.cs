using DrinkWorld.Data.Interfaces;
using DrinkWorld.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DrinkWorld.Controllers
{
    public class DrinkController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IDrinkRepository _drinkRepository;

        public DrinkController(ICategoryRepository categoryRepository, IDrinkRepository drinkRepository)
        {
            _categoryRepository = categoryRepository;
            _drinkRepository = drinkRepository;
        }

        public ViewResult List()
        {
            ViewBag.Name = "Abstergo drink world";
            DrinkListViewModel vm = new DrinkListViewModel
            {
                Drinks = _drinkRepository.Drinks,
                CurrentCategory = "DrinkCategory"
            };
            return View(vm);
        }
    }
}
