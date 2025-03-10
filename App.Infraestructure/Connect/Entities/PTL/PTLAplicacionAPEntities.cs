using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Infraestructure.Connect.Entities.PTL;

public class PTLAplicacionAPEntities
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]

    public int AplicacionId { get; set; }
    public string? NombreAplicacion { get; set; }
    public string? DescripcionAplicacion { get; set; }
    public bool EstadoAplicacion {  set; get; }

}
