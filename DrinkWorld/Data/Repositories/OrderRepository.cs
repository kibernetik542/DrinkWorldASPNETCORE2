using System;
using DrinkWorld.Data.Interfaces;
using DrinkWorld.Data.Models;

namespace DrinkWorld.Data.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepository(AppDbContext appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
           order.OrderPlaced = DateTime.Now;
            _appDbContext.Orders.Add(order);

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;

            foreach (var item in shoppingCartItems)
            {
                var od = new OrderDetail()
                {
                        Amount = item.Amount,
                        ProductId = item.Drink.DrinkId,
                        OrderId = order.OrderId,
                        Price = item.Drink.Price
                };
                _appDbContext.OrderDetails.Add(od);
            }
            _appDbContext.SaveChanges();
        }
    }
}
