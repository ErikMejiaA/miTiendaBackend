using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Configuration;

public class MovimientoBodegaConfiguration : IEntityTypeConfiguration<MovimientoBodega>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<MovimientoBodega> builder)
    {
        //definimos las propiedades de los atributos de la entidad

        builder.ToTable("MovimientosBodegas");

        builder.Property(p => p.IdDocumento)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.CreatedAt)
        .IsRequired()
        .HasColumnType("datetime");

        builder.Property(p => p.IdOriginCellar)
        .IsRequired()
        .HasMaxLength(50);
        

    }
}
