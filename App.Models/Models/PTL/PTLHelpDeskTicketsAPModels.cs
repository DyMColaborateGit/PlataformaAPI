
namespace App.Models.Models.PTL;

public class PTLHelpDeskTicketsAPModels
{
    public int TicketId { get; set; }
    public int AplicacionId { get; set; }
    public string? NombreTicket { get; set; }
    public string? DescripcionTicket { get; set; }
    public bool EstadoTicket { set; get; }
}
