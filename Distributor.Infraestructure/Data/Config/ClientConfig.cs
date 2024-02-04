using Distributor.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Distributor.Infraestructure.Data.Config
{
    public class ClientConfig : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder
                .HasKey(c => c.Id);

            builder.Property(c => c.Name).IsRequired().HasMaxLength(50);
            builder.Property(c => c.PhoneNumber).HasMaxLength(15);
            builder.Property(c => c.Address).IsRequired().HasMaxLength(100);

            // Relación con Reparto
            builder
                .HasOne(c => c.Reparto)
                .WithMany(r => r.Clients)
                .HasForeignKey(c => c.Id);


            // Relación Cliente y Pedido (1 a muchos)
            builder
                .HasMany(c => c.Orders)
                .WithOne(p => p.Client)
                .HasForeignKey(p => p.Id);

        }
    }
}
