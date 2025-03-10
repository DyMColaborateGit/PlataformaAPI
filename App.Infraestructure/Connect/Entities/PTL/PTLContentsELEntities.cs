using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Infraestructure.Connect.Entities.PTL;

public class PTLContentsELEntities
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public int ContentId { get; set; }
    public int EnlaceId { get; set; }
    public string? NombreContent { get; set; }
    public string? DescripcionContent { get; set; }
    public string? Contenido { get; set; }
    public bool EstadoContent { get; set; }
}
