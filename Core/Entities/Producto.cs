namespace Core.Entities;

public class Producto
{
    public int Id { get; set; }
    public string ? Name { get; set; }
    public string ? Description { get; set; }
    public int Quantity { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public double Price { get; set; }
    public int IdEstado { get; set; }


    //definimos las ICollection 
    public ICollection<ProductoUsuario> ? ProductosUsuarios { get; set; }

    //definimos una referencia hacia una entidad
    public Estado ? Estado { get; set; }
    
        
}
