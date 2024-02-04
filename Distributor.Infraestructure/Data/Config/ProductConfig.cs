using Distributor.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Distributor.Infraestructure.Data.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
                .HasKey(p => p.Id);

            builder.Property(p => p.Name).IsRequired().HasMaxLength(30);
            builder.Property(p => p.UnitPrice).IsRequired();
            builder.Property(p => p.Type).IsRequired().HasMaxLength(25);

            builder
                .HasMany(p => p.OrderDetail)
                .WithOne(od => od.Product)
                .HasForeignKey(p => p.Id);
        }
    }
}
