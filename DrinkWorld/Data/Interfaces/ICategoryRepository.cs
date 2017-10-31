using System.Collections.Generic;
using DrinkWorld.Data.Models;

namespace DrinkWorld.Data.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}
