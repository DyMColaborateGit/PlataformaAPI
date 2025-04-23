using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace App.Infraestructure.Connect.Entities.PTL;

public class PTLConexionesBDEntities
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public int ConexionId { get; set; }
    public int AplicacionId { get; set; }
    public int SuscriptorId { get; set; }
    public string? NombreConexion { get; set; }
    public string? DescripcionConexion { get; set; }
    public bool EstadoConexion { set; get; }
}
