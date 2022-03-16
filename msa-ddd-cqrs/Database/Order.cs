namespace msa_ddd_cqrs.Database
{
    public class Order
    {
        public int Id { get; set; }
        public Guid BuyerId { get; set; }
        public string Address { get; set; }
        public string OrderStatus { get; set; }
        public bool IsDraft { get; set; }


        public List<OrderItem> OrderItems { get; set; }
    }
}
