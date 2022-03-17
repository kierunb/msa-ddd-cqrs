using msa_ddd_cqrs.Domain.Aggregates.Order;
using System;
using Xunit;

namespace msa_ddd_cqrs.UnitTests;

public class OrderAggregateTests
{
    //[Fact]
    //public void AnemicModelUsageTest()
    //{
    //    var order = new Order { Id = 1, Address = "Address 1", IsDraft = true };
    //    order.OrderItems.Add(new OrderItem { Name = "Item 1", Price = 12.34M });

    //    Assert.True(order is not null);
    //}

    [Fact]
    public void RichModelUsageTest1()
    {
        var order = new Order(buyerId: Guid.NewGuid(), address: "Address 1", isDraft: false );
        order.SetAsCreated();
        order.AddOrderItem(name: "Product 1", price: 12.34M, units: 3);

        Assert.True(order is not null);
    }
}
