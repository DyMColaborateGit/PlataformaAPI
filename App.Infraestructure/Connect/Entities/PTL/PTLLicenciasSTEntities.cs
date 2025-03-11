using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace App.Infraestructure.Connect.Entities.PTL;

public class PTLLicenciasSTEntities
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public int LicenciaId { get; set; }
    public int SuscriptorId { get; set; }
    public string? NombreLicencia { get; set; }
    public string? DescripcionLicencia { get; set; }
    public bool EstadoLicencia { set; get; }
}
