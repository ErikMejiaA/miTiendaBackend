using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class ProductoUsuarioConfiguration : IEntityTypeConfiguration<ProductoUsuario>
{
    public void Configure(EntityTypeBuilder<ProductoUsuario> builder)
    {
        //definimos las  propiedades de los atributos de la entidad ProductoUsuario

        //definimos las llavez foranes FOREIGN KEY
        builder.HasOne(p => p.User)
        .WithMany(p => p.ProductosUsuarios)
        .HasForeignKey(p => p.IdUser)
        .IsRequired();

        builder.HasOne(p => p.Producto)
        .WithMany(p => p.ProductosUsuarios)
        .HasForeignKey(p => p.IdProducto)
        .IsRequired();

    }
}
