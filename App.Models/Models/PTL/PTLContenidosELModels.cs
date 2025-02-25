using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Models.PTL;

public class PTLContenidosELModels
{
    public int ContenidoId { get; set; }
    public int EnlaceId { get; set; }
    public string? NombreContenido { get; set; }
    public string? DescripcionContenido { get; set; }
    public string? Contenido { get; set; }
    public bool EstadoContenido { get; set; }
}

