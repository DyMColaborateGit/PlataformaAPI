
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace App.Infraestructure.Connect.Entities.PTL;

public class PTLUsuariosSTEntities
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public int UsuarioId { get; set; }
    public int SuscriptorId { get; set; }
    public string? NombreUsuario { get; set; }
    public string? DescripcionUsuario { get; set; }
    public bool EstadoUsuario { set; get; }
}
