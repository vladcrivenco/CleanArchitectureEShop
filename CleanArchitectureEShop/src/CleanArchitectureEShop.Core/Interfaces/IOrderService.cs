using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureEShop.Core.Interfaces
{
    public interface IOrderService
    {
        Task CreateOrderAsync(int basketId);
    }
}
