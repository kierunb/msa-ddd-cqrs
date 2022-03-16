using Microsoft.EntityFrameworkCore;
using msa_ddd_cqrs.Domain.Aggregates.Order;

namespace msa_ddd_cqrs.Database;

public class OrdersDbContext : DbContext
{
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }

    public OrdersDbContext()
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={AppContext.BaseDirectory}orders.db");
}
