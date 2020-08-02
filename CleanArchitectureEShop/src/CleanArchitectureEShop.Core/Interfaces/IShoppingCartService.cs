using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureEShop.Core.Interfaces
{
    public interface IShoppingCartService
    {
        Task AddItemToShoppingCart(int cartId, int productItemId, decimal price, int quantity = 1);
        Task SetQuantities(int cartId, Dictionary<string, int> quantities);
        Task DeleteShoppingCartAsync(int cartId);
    }
}
