namespace App.Models.Models.PTL;

public class PTLUsuariosModels
{
    public int UsuarioId { get; set; }
    public string? FotoUsuario { get; set; }
    public string? NombreUsuario { get; set; }
    public string? DescripcionUsuario { get; set; }
    public string? ClaveUsuario { get; set; }
    public string? CorreoUsuario { get; set; }
    public bool EstadoUsuario { set; get; }
}
