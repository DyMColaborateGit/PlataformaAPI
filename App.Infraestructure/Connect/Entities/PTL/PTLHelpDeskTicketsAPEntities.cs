using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace App.Infraestructure.Connect.Entities.PTL;

public class PTLHelpDeskTicketsAPEntities
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]

    public int TicketId { get; set; }
    public int AplicacionId { get; set; }
    public string? NombreTicket { get; set; }
    public string? DescripcionTicket { get; set; }
    public bool EstadoTicket { set; get; }
}