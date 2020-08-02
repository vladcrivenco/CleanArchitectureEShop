using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureEShop.Core.Entities.OrderAgreggate
{
    public class OrderedCatalogItem
    {
        public int CatalogItemName { get; private set; }
        public int CatalogItemPicture { get; private set; }
        public int CatalogItemId { get; private set; }
    }
}
