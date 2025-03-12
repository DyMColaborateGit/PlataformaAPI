
namespace App.Models.Models.PTL;

public class PTLLogTransaccionesAPModels
{
    public int LogId { get; set; }
    public int AplicacionId { get; set; }
    public DateTime Fecha { get; set; }
    public string? DescripcionLog { get; set; }
}
