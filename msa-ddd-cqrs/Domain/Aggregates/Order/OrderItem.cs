using msa_ddd_cqrs.Domain.Shared;

namespace msa_ddd_cqrs.Domain.Aggregates.Order;

public class OrderItem : Entity
{
    // fields could be also private for better encapsulation
    // 'Id' inhreited from Entity base class

    public string Name { get; private set; }
    public decimal Price { get; private set; }
    public int Units { get; private set; }

    protected OrderItem() { }
    public OrderItem(string name, decimal price, int units)
    {
        Name = name;
        Price = price;
        Units = units;
    }
}
