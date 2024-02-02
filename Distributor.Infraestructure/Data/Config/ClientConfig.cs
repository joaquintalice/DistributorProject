using Distributor.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Distributor.Infraestructure.Data.Config
{
    public class ClientConfig : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(c => c.Id);

            // Relación Cliente y Pedido (1 a muchos)
            builder.HasMany(c => c.Orders)
                .WithOne(p => p.Client)
                .HasForeignKey(p => p.Id);
        }
    }
}
