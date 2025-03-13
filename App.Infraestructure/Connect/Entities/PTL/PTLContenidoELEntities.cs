using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Infraestructure.Connect.Entities.PTL;

public class PTLContenidoELEntities
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public int ContenidoId { get; set; }
    public int EnlaceId { get; set; }
    public string? NombreContenido { get; set; }
    public string? DescripcionContenido { get; set; }
    public string? Contenido { get; set; }
    public bool EstadoContenido { get; set; }
}
