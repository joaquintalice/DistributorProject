namespace Distributor.Core.Entities
{
    public class Employee : BaseEntity
    {
        public string Name { get; set; }
        public string Asignation { get; set; }

        public Truck Truck { get; set; }
    }
}
