using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace App.Infraestructure.Connect.Entities.PTL;

public class PTLUsuariosEntities
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public int UsuarioId { get; set; }
    public string? FotoUsuario { get; set; }
    public int IdentificacionUsuario { get; set; }
    public string? NombreUsuario { get; set; }
    public string? DescripcionUsuario { get; set; }
    public string? ClaveUsuario { get; set; }
    public string? CorreoUsuario { get; set; }
    public bool EstadoUsuario { set; get; }
}
