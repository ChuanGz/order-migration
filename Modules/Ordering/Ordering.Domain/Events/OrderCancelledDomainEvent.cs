namespace Microsoft.eShopOnContainers.Services.Ordering.Domain.Events;

public class OrderCancelledDomainEvent
{
    public Order Order { get; }

    public OrderCancelledDomainEvent(Order order)
    {
        Order = order;
    }
}