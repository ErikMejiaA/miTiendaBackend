using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Bodega
{
    [Key]
    public string ? IdBodega { get; set; }
    public string ? NameCellar { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    
            
}
