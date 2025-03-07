using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Models.PTL;

public class PTLHelpDeskTicketAPModels
{
    public int TicketId { get; set; }
    public int AplicacionId { get; set; }
    public string? NombreTicket { get; set; }
    public string? DescripcionTicket { get; set; }
    public bool EstadoTicket { set; get; }
}
