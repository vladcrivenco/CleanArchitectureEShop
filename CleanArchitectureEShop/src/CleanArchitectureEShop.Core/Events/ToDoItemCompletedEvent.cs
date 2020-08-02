using CleanArchitectureEShop.Core.Entities;
using CleanArchitectureEShop.SharedKernel;

namespace CleanArchitectureEShop.Core.Events
{
    public class ToDoItemCompletedEvent : BaseDomainEvent
    {
        public ToDoItem CompletedItem { get; set; }

        public ToDoItemCompletedEvent(ToDoItem completedItem)
        {
            CompletedItem = completedItem;
        }
    }
}