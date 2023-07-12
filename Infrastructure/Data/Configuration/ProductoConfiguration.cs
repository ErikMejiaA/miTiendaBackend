using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
{
    public void Configure(EntityTypeBuilder<Producto> builder)
    {
        //definimos las propiedades para los atributos de la entidad Producto

        builder.ToTable("Productos");

        builder.Property(p => p.Id)
        .IsRequired();

        builder.Property(p => p.Name)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.Description)
        .IsRequired()
        .HasMaxLength(100);

        builder.Property(p => p.Quantity)
        .IsRequired();

        builder.Property(p => p.CreatedAt)
        .IsRequired()
        .HasColumnType("datetime");

        builder.Property(p => p.UpdatedAt)
        .IsRequired()
        .HasColumnName("datetime");

        builder.Property(p => p.Price)
        .IsRequired()
        .HasColumnType("decimal");

        //creamos las llaves FOREIGN KEY
        
        builder.HasOne(p => p.Estado)
        .WithMany(p => p.Productos)
        .HasForeignKey(p => p.IdEstado)
        .IsRequired();
    }
}
