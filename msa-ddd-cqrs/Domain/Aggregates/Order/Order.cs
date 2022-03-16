using msa_ddd_cqrs.Domain.Shared;

namespace msa_ddd_cqrs.Domain.Aggregates.Order;

public class Order : Entity, IAggregateRoot
{
    // fields could be also private for better encapsulation
    // 'Id' inhreited from Entity base class

    public Guid BuyerId { get; private set; }
    public string Address { get; private set; }
    public string OrderStatus { get; private set; }
    public bool IsDraft { get; private set; }


    public List<OrderItem> OrderItems { get; private set; } = new();

    protected Order() { }

    public Order(Guid buyerId, string address, string orderStatus, bool isDraft)
    {
        BuyerId = buyerId;
        Address = address;
        OrderStatus = orderStatus;
        IsDraft = isDraft;
    }

    public void AddOrderItem(string name, decimal price, int units)
    {
        var orderItem = new OrderItem(name, price, units);
        OrderItems.Add(orderItem);
    }
}
