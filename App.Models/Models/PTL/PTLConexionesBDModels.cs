namespace App.Models.Models.PTL;

public class PTLConexionesBDModels
{
    public int ConexionId { get; set; }
    public int AplicacionId { get; set; }
    public int SuscriptorId { get; set; }
    public string? NombreConexion { get; set; }
    public string? DescripcionConexion { get; set; }
    public bool EstadoConexion { set; get; }
}
