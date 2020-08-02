using System.Threading.Tasks;
using CleanArchitectureEShop.SharedKernel;

namespace CleanArchitectureEShop.SharedKernel.Interfaces
{
    public interface IHandle<in T> where T : BaseDomainEvent
    {
        Task Handle(T domainEvent);
    }
}