using Distributor.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Distributor.Infraestructure.Data.Config
{
    public class RepartoConfig : IEntityTypeConfiguration<Reparto>
    {
        public void Configure(EntityTypeBuilder<Reparto> builder)
        {
            builder
                .HasKey(r => r.Id);

            builder.Property(r => r.Name).HasMaxLength(30);
            builder.Property(r => r.Location).HasMaxLength(50);

            builder
                .HasMany(r => r.Trucks)
                .WithOne(t => t.Reparto)
                .HasForeignKey(t => t.Id);

            builder
                .HasMany(r => r.Clients)
                .WithOne(cl => cl.Reparto)
                .HasForeignKey(cl => cl.Id);
        }
    }
}
