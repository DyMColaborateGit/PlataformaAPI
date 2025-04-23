namespace App.Models.Models.PTL;

public class PTLSuscriptoresAPModels
{
    public int SuscriptorId { get; set; }
    public int AplicacionId { get; set; }
    public string? NombreSuscriptor { get; set; }
    public string? DescripcionSuscriptor { get; set; }
    public bool EstadoSuscriptor { set; get; }
}
