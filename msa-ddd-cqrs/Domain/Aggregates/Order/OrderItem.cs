using msa_ddd_cqrs.Domain.Exceptions;
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
        if (units <= 0)
        {
            throw new OrderingDomainException("Invalid number of units");
        }

        Name = name;
        Price = price;
        Units = units;
    }

    public decimal GetUnitPrice()
    {
        return Price;
    }
}
