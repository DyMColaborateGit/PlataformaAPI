using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace App.Infraestructure.Connect.Entities.PTL;

public class PTLLogTransaccionesAPEntities
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public int LogId { get; set; }
    public int AplicacionId { get; set; }
    public DateTime Fecha { get; set; }
    public string? DescripcionLog { get; set; }
}
