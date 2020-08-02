using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureEShop.Core.Interfaces
{
    public interface IRefundService
    {
        Task Refund(int orderId);
    }
}
