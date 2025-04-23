using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Models.PTL;

public class PTLEnlacesSTModels
{
    public int EnlaceId { get; set; }
    public int SitioId { get; set; }
    public string? NombreEnlace { get; set; }
    public string? DescripcionEnlace { get; set; }
    public string? RutaEnlace { get; set; }
    public bool EstadoEnlace { get; set; }
}
