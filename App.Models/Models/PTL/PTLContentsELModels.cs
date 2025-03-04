using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Models.PTL;

public class PTLContentsELModels
{
    public int ContentId { get; set; }
    public int EnlaceId { get; set; }
    public string? NombreContent { get; set; }
    public string? DescripcionContent { get; set; }
    public string? Contenido { get; set; }
    public bool EstadoContent { get; set; }
}

