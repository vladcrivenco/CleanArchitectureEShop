using Ardalis.Specification;
using CleanArchitectureEShop.Core.Entities.ShoppingCartAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureEShop.Core.Specifications
{
    public sealed class BasketWithItemsSpecification : Specification<ShoppingCart>
    {
        public BasketWithItemsSpecification(int basketId)
        {
            Query
                .Where(b => b.Id == basketId)
                .Include(b => b.Items);
        }

        public BasketWithItemsSpecification(string buyerId)
        {
            Query
                .Where(b => b.BuyerId == buyerId)
                .Include(b => b.Items);
        }
    }
}
