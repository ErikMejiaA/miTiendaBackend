using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class MovimientoBodega
{
    [Key]
    public string ? IdDocumento { get; set; }
    public DateTime CreatedAt { get; set; }
    public string ? IdOriginCellar { get; set; }
    
        
}
