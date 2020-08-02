using Ardalis.GuardClauses;
using CleanArchitectureEShop.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureEShop.Core.Entities.ShoppingCartAggregate
{
    public class ShoppingCartItem : BaseEntity
    {
        public decimal UnitPrice { get; private set; }

        public int Quantity { get; private set; }

        public int ProductItemId { get; private set; }

        public int BasketId { get; private set; }

        public ShoppingCartItem(int productItemId, int quantity, decimal unitPrice)
        {
            ProductItemId = productItemId;
            UnitPrice = unitPrice;
            SetQuantity(quantity);
        }


        public void AddQuantity(int quantity)
        {
            Guard.Against.OutOfRange(quantity, nameof(quantity), 0, int.MaxValue - Quantity);

            Quantity += quantity;
        }


        public void SetQuantity(int quantity)
        {
            Guard.Against.OutOfRange(quantity, nameof(quantity), 0, int.MaxValue);
            Quantity = quantity;
        }
    }
}
