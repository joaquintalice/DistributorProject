using Distributor.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Distributor.Infraestructure.Data.Config
{
    public class CamionConfiguration : IEntityTypeConfiguration<Truck>
    {
        public void Configure(EntityTypeBuilder<Truck> builder)
        {
            builder
                .HasKey(t => t.Id);

            builder.Property(t => t.LicensePlate).IsRequired().HasMaxLength(15);
            builder.Property(t => t.Name).IsRequired().HasMaxLength(50);
            builder.Property(t => t.Brand).IsRequired().HasMaxLength(20);
            builder.Property(t => t.Model).IsRequired().HasMaxLength(30);

            builder
                .HasOne(t => t.Reparto)
                .WithMany(r => r.Trucks)
                .HasForeignKey(t => t.Id);

            builder.HasOne(t => t.Employee)
                .WithOne(e => e.Truck)
                .HasForeignKey<Employee>(e => e.Id);
        }
    }
}
