namespace Distributor.Core.Entities
{
    public class Order : BaseEntity
    {
        public DateTime OrderDate { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }

        public List<OrderDetail> OrderDetail { get; set; }
    }
}
