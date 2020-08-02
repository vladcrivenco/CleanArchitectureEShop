using CleanArchitectureEShop.Core.Interfaces;
using CleanArchitectureEShop.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureEShop.Core.Entities.BuyerAggregate
{
    public class Buyer: BaseEntity, IAggregateRoot
    {
        public Wallet Wallet { get; private set; }
    }
}
