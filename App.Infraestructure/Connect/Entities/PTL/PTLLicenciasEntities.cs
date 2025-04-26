using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace App.Infraestructure.Connect.Entities.PTL;

public class PTLLicenciasEntities
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public int LicenciaId { get; set; }
    public int SuscriptorId { get; set; }
    public int AplicacionId { set; get; }
    public string? NombreLicencia { get; set; }
    public string? DescripcionLicencia { get; set; }
    public bool EstadoLicencia { set; get; }
    public DateTime FechaCreacion { set; get; }
    public DateTime FechaVencimiento { set; get; }
}
