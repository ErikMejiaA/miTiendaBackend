using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Configuration;

public class DetalleMovimientoConfiguration : IEntityTypeConfiguration<DetalleMovimiento>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<DetalleMovimiento> builder)
    {
        //Definimos las propiedades de los atributos de la entidad 

        builder.ToTable("DetallesMovimientos");

        builder.Property(p=> p.Id)
        .IsRequired();

        builder.Property(p => p.DestinyCellar)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p .AddresDestiny)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.ProductsQuantity)
        .IsRequired()
        .HasColumnType("int");

        
    }
}
