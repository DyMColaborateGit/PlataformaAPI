using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace App.Infraestructure.Connect.Entities.PTL;

public class PTLRequerimientosHDEntities
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]

    public int RequerimientoId { get; set; }
    public int TicketId { get; set; }
    public string? NombreRequerimiento { get; set; }
    public string? DescripcionRequerimiento { get; set; }
    public bool EstadoRequerimiento { set; get; }
}
