namespace App.Models.Models.PTL;

public class PTLRequerimientosHDModels
{
    public int RequerimientoId { get; set; }
    public int TicketId { get; set; }
    public string? NombreRequerimiento { get; set; }
    public string? DescripcionRequerimiento { get; set; }
    public bool EstadoRequerimiento { set; get; }
}
