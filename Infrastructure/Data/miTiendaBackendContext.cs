using System.Reflection;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class miTiendaBackendContext : DbContext
{
    public miTiendaBackendContext(DbContextOptions<miTiendaBackendContext> options) : base(options)
    {

    }

    //aqui se van a cargar los DbSet<>
    public DbSet<User> ? Users { get; set; }
    public DbSet<Producto> ? Productos { get; set; }
    public DbSet<ProductoUsuario> ? ProductosUsuarios { get; set; }
    public DbSet<Bodega> ? Bodegas { get; set; }
    public DbSet<DetalleMovimiento> ? DetallesMovimientos { get; set; }
    public DbSet<Estado> ? Estados { get; set; }
    public DbSet<MovimientoBodega> ? MovimientosBodegas { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //definimos las llaves compuestas de la entidad de ProductoUsuario 
        //que relaciona la relacion de muchos a muchos
        modelBuilder.Entity<ProductoUsuario>().HasKey(p => new {p.IdProducto, p.IdUser});

        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

}
