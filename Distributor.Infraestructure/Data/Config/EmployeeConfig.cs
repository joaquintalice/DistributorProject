using Distributor.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Distributor.Infraestructure.Data.Config
{
    public class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder
                .HasKey(e => e.Id);

            builder.Property(e => e.Name).IsRequired().HasMaxLength(30);
            builder.Property(e => e.Asignation).HasMaxLength(50);

            builder
                .HasOne(e => e.Truck)
                .WithOne(t => t.Employee)
                .HasForeignKey<Truck>(t => t.Id);
        }
    }
}
