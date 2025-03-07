using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace App.Infraestructure.Connect.Entities.PTL;

public class PTLVersionesAPEntities
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]

    public int VersionesId { get; set; }
    public int AplicacionId { get; set; }
    public string? NombreVersion { get; set; }
    public string? DescripcionVersion { get; set; }
    public bool EstadoVersion { set; get; }
}
