using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace App.Infraestructure.Connect.Entities.PTL;

public class PTLSuscriptorAPEntities
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public int SuscriptorId { get; set; }
    public int AplicacionId { get; set; }
    public string? NombreSuscriptor { get; set; }
    public string? DescripcionSuscriptor { get; set; }
    public bool EstadoSuscriptor { set; get; }
}
