using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using DrinkWorld.Data.Interfaces;
using DrinkWorld.Data.Models;
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

        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Drink> drinks;

            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                drinks = _drinkRepository.Drinks.OrderBy(p => p.DrinkId);
                currentCategory = "All drinks";
            }
            else
            {
                if (string.Equals("Alcoholic",_category, StringComparison.OrdinalIgnoreCase))
                {
                    drinks = _drinkRepository.Drinks.Where(p => p.Category.CategoryName.Equals("Alcoholic"))
                        .OrderBy(c => c.Name);
                }
                else
                    drinks = _drinkRepository.Drinks.Where(p => p.Category.CategoryName.Equals("Non-alcoholic"))
                    .OrderBy(c => c.Name);
                currentCategory = _category;
            }
            var dlvm = new DrinkListViewModel
            {
                Drinks = drinks,
                CurrentCategory = currentCategory
            };
            return View(dlvm);
        }
        public IActionResult Details(int id)
        {
            var product = _drinkRepository.GetDrinkById(id);
            if (product == null)
                return NotFound();

            return View(product);
        }

    }
}
