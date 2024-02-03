namespace Distributor.Core.Entities
{
    public class Client : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }

        public Reparto Reparto { get; set; }
        public List<Order> Orders { get; set; }
    }
}
