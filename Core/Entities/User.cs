namespace Core.Entities;

public class User
{
    public int Id { get; set; }
    public string ? Name { get; set; }
    public string ? Email { get; set; }
    public DateTime UpdatedDate { get; set; }
    public string ? Picture { get; set; }
    public string ? Password { get; set; }

    //generamos los ICollection
    public ICollection<ProductoUsuario> ? ProductosUsuarios { get; set; }
        
}
