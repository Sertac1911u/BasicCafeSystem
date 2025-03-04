namespace OOPWithNLayer.Entity.Concrete
{
    public class Order
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalePrice { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public bool CustomerStatus { get; set; }
    }
}
