using Ardalis.GuardClauses;
using CleanArchitectureEShop.Core.Interfaces;
using CleanArchitectureEShop.SharedKernel;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CleanArchitectureEShop.Core.Entities.ShoppingCartAggregate
{
    public class ShoppingCart: BaseEntity, IAggregateRoot
    {
        public string BuyerId{ get; private set; }

        private readonly List<ShoppingCartItem> _items = new List<ShoppingCartItem>();
        public IReadOnlyCollection<ShoppingCartItem> Items => _items.AsReadOnly();

        public ShoppingCart(string buyerId)
        {
            Guard.Against.NullOrEmpty(buyerId, nameof(buyerId));

            BuyerId = buyerId;
        }

        public void AddItem(int productItemId, decimal unitPrice, int quantity = 1)
        {
            if (!Items.Any(i => i.ProductItemId == productItemId))
            {
                _items.Add(new ShoppingCartItem(productItemId, quantity, unitPrice));
                return;
            }
            var existingItem = Items.FirstOrDefault(i => i.ProductItemId == productItemId);
            existingItem.AddQuantity(quantity);
        }

        public void RemoveEmptyItems()
        {
            _items.RemoveAll(i => i.Quantity == 0);
        }
    }
}
