using System.Threading.Tasks;
using CleanArchitectureEShop.SharedKernel.Interfaces;
using CleanArchitectureEShop.SharedKernel;

namespace CleanArchitectureEShop.UnitTests
{
    public class NoOpDomainEventDispatcher : IDomainEventDispatcher
    {
        public Task Dispatch(BaseDomainEvent domainEvent)
        {
            return Task.CompletedTask;
        }
    }
}
