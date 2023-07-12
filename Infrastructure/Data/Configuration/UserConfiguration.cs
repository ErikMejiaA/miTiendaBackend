using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        //definimos las propiedades de los atrinutos de la entidad User
        builder.ToTable("Users");

        builder.Property(p => p.Id)
        .IsRequired();

        builder.Property(p => p.Name)
        .IsRequired()
        .HasMaxLength(50);
        
        builder.Property(p => p.Email)
        .IsRequired()
        .HasMaxLength(50);

        builder.HasIndex(p => p.Email)
        .IsUnique();

        builder.Property(p => p.Picture)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.Password)
        .IsRequired()
        .HasMaxLength(50);
        
    }
}
