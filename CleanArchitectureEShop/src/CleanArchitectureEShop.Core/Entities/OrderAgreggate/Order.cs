using CleanArchitectureEShop.Core.Interfaces;
using CleanArchitectureEShop.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanArchitectureEShop.Core.Entities.OrderAgreggate
{
    public class Order: BaseEntity, IAggregateRoot
    {
        public int BuyerId { get; set; }

        private readonly List<OrderItem> _items = new List<OrderItem>();

        public IReadOnlyCollection<OrderItem> Items => _items.AsReadOnly();

        public decimal Total => Items.Sum(x => x.Quantity * x.UnitPrice);
    }
}
