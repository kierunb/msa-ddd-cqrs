namespace msa_ddd_cqrs.Domain.Aggregates.Order;

public class OrderItem
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Units { get; set; }
}
