using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Models.PTL;

public class PTLAplicacionAPModels
{
    public int AplicacionId { get; set; }
    public string? NombreAplicacion { get; set; }
    public string? DescripcionAplicacion { get; set; }
    public bool EstadoAplicacion { set; get; }
}
