using DrinkWorld.Data.Models;

namespace DrinkWorld.Data.Interfaces
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
