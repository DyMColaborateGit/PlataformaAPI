
namespace App.Models.Models.PTL;

public class PTLVersionesAPModels
{
    public int VersionesId { get; set; }
    public int AplicacionId { get; set; }
    public string? NombreVersion { get; set; }
    public string? DescripcionVersion { get; set; }
    public bool EstadoVersion { set; get; }
}
