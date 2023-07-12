using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Configuration;

public class EstadoConfiguration : IEntityTypeConfiguration<Estado>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Estado> builder)
    {
        //definimos las propiedades de los atributos de la entidad

        builder.ToTable("Estados");

        builder.Property(p => p.Description)
        .IsRequired()
        .HasMaxLength(50);

        
    }
}
