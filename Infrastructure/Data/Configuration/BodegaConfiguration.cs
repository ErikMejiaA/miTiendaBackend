using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Configuration;

public class BodegaConfiguration : IEntityTypeConfiguration<Bodega>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Bodega> builder)
    {
        //escribimos las propiedades de los atributos de la entidad Bodega
        builder.ToTable("Bodegas");

        builder.Property(p => p.IdBodega)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.NameCellar)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.CreatedAt)
        .IsRequired()
        .HasColumnType("datetime");

        builder.Property(p => p.UpdatedAt)
        .IsRequired()
        .HasColumnType("datetime");

        
    }
}
