using CleanArchitectureEShop.Core.Interfaces;
using CleanArchitectureEShop.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureEShop.Core.Entities.CatalogAggregate
{
    public class Catalog: BaseEntity, IAggregateRoot
    {
        private readonly List<CatalogItem> _items = new List<CatalogItem>();

        public IReadOnlyCollection<CatalogItem> Items => _items.AsReadOnly();
    }
}
