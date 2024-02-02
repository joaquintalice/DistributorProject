namespace Distributor.Core.Entities
{
    public class Reparto : BaseEntity
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public List<Client> Clients { get; set; }
        public List<Truck> Trucks { get; set; }
    }
}
