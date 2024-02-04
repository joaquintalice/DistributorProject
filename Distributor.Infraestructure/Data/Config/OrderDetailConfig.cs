using Distributor.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Distributor.Infraestructure.Data.Config
{
    public class OrderDetailConfig : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder.Property(x => x.Quantity).IsRequired();
            builder.Property(x => x.UnitPrice).IsRequired();

            builder
                .HasOne(od => od.Order)
                .WithMany(o => o.OrderDetail)
                .HasForeignKey(o => o.OrderId);

            builder
                .HasOne(od => od.Product)
                .WithMany(p => p.OrderDetail)
                .HasForeignKey(o => o.ProductId);
        }
    }
}