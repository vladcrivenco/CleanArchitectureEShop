using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureEShop.Core.Interfaces
{
    public interface ICheckoutService
    {
        Task Checkout(int basketId);
    }
}
