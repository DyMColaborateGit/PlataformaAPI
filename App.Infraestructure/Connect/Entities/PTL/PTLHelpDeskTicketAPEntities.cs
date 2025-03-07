using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infraestructure.Connect.Entities.PTL;

public class PTLHelpDeskTicketAPEntities
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]

    public int TicketId { get; set; }
    public int AplicacionId { get; set; }
    public string? NombreTicket { get; set; }
    public string? DescripcionTicket { get; set; }
    public bool EstadoTicket { set; get; }
}