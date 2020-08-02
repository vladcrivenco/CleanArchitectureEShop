using CleanArchitectureEShop.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureEShop.Core.Entities.OrderAgreggate
{
    public class OrderItem: BaseEntity
    {
        public OrderedCatalogItem OrderedItem { get; private set; }
        public int Quantity { get; private set; }
        public decimal UnitPrice { get; private set; }
    }
}
