namespace Microsoft.eShopOnContainers.Services.Ordering.Domain.Events;

public class OrderShippedDomainEvent
{
    public Order Order { get; }

    public OrderShippedDomainEvent(Order order)
    {
        Order = order;
    }
}