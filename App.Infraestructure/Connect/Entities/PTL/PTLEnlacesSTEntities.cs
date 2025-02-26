using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Infraestructure.Connect.Entities.PTL;

public class PTLEnlacesSTEntities
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public int EnlaceId { get; set; }
    public int SitioId { get; set; }
    public string? NombreEnlace { get; set; }
    public string? DescripcionEnlace { get; set; }
    public string? RutaEnlace { get; set; }
    public bool EstadoEnlace { get; set; }
    public ICollection<PTLContenidosELEntities>? PTLContenidosEL { get; set; }
}
