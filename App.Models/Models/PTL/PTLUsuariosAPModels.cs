

namespace App.Models.Models.PTL;

public class PTLUsuariosAPModels
{
    public int UsuarioId { get; set; }
    public string? NombreUsuario { get; set; }
    public string? ClaveUsuario { get; set; }
    public string? CorreoUsuario { get; set; }
    public bool EstadoUsuario { set; get; }
    public int AplicacionId { set; get; }
}
