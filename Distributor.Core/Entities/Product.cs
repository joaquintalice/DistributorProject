namespace Distributor.Core.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal UnitPrice { get; set; }

        public List<OrderDetail> OrderDetail { get; set; }
    }
}
