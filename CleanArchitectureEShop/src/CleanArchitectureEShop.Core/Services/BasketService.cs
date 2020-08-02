using Ardalis.GuardClauses;
using CleanArchitectureEShop.Core.Entities.ShoppingCartAggregate;
using CleanArchitectureEShop.Core.Interfaces;
using CleanArchitectureEShop.Core.Specifications;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureEShop.Core.Services
{
    public class ShoppingCartService : IShoppingCartService
    {
        private readonly IRepository<ShoppingCart> _shoppingCartRepository;

        public ShoppingCartService(IRepository<ShoppingCart> shoppingCartRepository)
        {
            _shoppingCartRepository = shoppingCartRepository;
        }

        public async Task AddItemToShoppingCart(int basketId, int productItemId, decimal price, int quantity = 1)
        {
            var shoppingCartSpecification = new BasketWithItemsSpecification(basketId);
            var shoppingCart = await _shoppingCartRepository.FirstOrDefaultAsync(shoppingCartSpecification);
            Guard.Against.Null(shoppingCart, nameof(shoppingCart));

            shoppingCart.AddItem(productItemId, price, quantity);

            await _shoppingCartRepository.UpdateAsync(shoppingCart);
        }

        public async Task DeleteShoppingCartAsync(int basketId)
        {
            var basket = await _shoppingCartRepository.GetByIdAsync(basketId);
            await _shoppingCartRepository.DeleteAsync(basket);
        }

        public async Task SetQuantities(int basketId, Dictionary<string, int> quantities)
        {
            Guard.Against.Null(quantities, nameof(quantities));

            var shoppingCartSpecification = new BasketWithItemsSpecification(basketId);
            var shoppingCart = await _shoppingCartRepository.FirstOrDefaultAsync(shoppingCartSpecification);
            Guard.Against.Null(shoppingCart, nameof(shoppingCart));

            foreach (var item in shoppingCart.Items)
            {
                if (quantities.TryGetValue(item.Id.ToString(), out var quantity))
                {
                    item.SetQuantity(quantity);
                }
            }
            shoppingCart.RemoveEmptyItems();
            await _shoppingCartRepository.UpdateAsync(shoppingCart);
        }
    }
}
