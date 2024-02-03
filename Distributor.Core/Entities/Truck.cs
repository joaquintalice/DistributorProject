namespace Distributor.Core.Entities
{
    public class Truck : BaseEntity
    {
        public string Name { get; set; }
        public int LicensePlate { get; set; }
        public int Brand { get; set; }
        public int Model { get; set; }
        public int ClientId { get; set; }
        public Reparto Reparto { get; set; }
        public Employee Employee { get; set; }
    }
}
