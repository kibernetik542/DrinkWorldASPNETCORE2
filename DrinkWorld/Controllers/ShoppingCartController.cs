using System.Linq;
using DrinkWorld.Data.Interfaces;
using DrinkWorld.Data.Models;
using DrinkWorld.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DrinkWorld.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IDrinkRepository _drinkRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IDrinkRepository drinkRepository, ShoppingCart shoppingCart)
        {
            _drinkRepository = drinkRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var scvm = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(scvm);
        }

        public RedirectToActionResult AddToShoppingCart(int drinkId)
        {
            var selectedDrink = _drinkRepository.Drinks.FirstOrDefault(
                p => p.DrinkId == drinkId);

            if (selectedDrink != null)
            {
                _shoppingCart.AddToCart(selectedDrink,1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int drinkId)
        {
            var selectedDrink = _drinkRepository.Drinks.FirstOrDefault(
                p => p.DrinkId == drinkId);

            if (selectedDrink != null)
            {
                _shoppingCart.RemoveFromCart(selectedDrink);
            }
            return RedirectToAction("Index");
        }


    }
}
