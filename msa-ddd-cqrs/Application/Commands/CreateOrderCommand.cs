namespace msa_ddd_cqrs.Application.Commands;

public class CreateOrderCommand
{
    public Guid BuyerId { get; set; }
    public string Address { get; set; }
}
