using System.Threading.Tasks;
using CleanArchitectureEShop.SharedKernel;

namespace CleanArchitectureEShop.SharedKernel.Interfaces
{
    public interface IDomainEventDispatcher
    {
        Task Dispatch(BaseDomainEvent domainEvent);
    }
}