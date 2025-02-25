using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Models.PTL;

public class PTLSitiosModels
{
    public int SitioId { get; set; }
    public string? NombreSitio { get; set; }
    public string? DescripcionSitio { get; set; }
    public string? UrlSitio { get; set; }
    public bool EstadoSitio { get; set; }
}
