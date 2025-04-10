using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace App.Infraestructure.Connect.Entities.PTL;

public class PTLSeguimientosRQEntities
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public int SeguimientoId { get; set; }
    public int RequerimientoId { get; set; }
    public string? NombreSeguimiento { get; set; }
    public string? DescripcionSeguimiento { get; set; }
    public bool EstadoSeguimiento { set; get; }
}
