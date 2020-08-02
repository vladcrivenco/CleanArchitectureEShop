using CleanArchitectureEShop.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureEShop.Core.Entities.CatalogAggregate
{
    public class CatalogItem: BaseEntity
    {
        public string Name { get; private set; }

        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public string PictureUri { get; private set; }

        public CatalogItem(string name, string description, decimal price, string pictureUri)
        {
            Name = name;
            Description = description;
            Price = price;
            PictureUri = pictureUri;
        }
    }
}
