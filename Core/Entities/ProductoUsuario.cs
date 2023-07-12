using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class ProductoUsuario
{
    public int IdUser { get; set; }
    public int IdProducto { get; set; }

    //hacemos las relaciones
    public User ? User { get; set; }
    public Producto ? Producto { get; set; }
        
}
