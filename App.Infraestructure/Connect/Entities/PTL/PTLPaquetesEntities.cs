using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace App.Infraestructure.Connect.Entities.PTL;

public class PTLPaquetesEntities
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public int PaquetesId { get; set; }
    public int LicenciaId { get; set; }
    public int AplicacionId { get; set; }
    public string? NombrePaquetes { get; set; }
    public string? DescripcionPaquetes { get; set; }
    public bool EstadoPaquetes { set; get; }
}
