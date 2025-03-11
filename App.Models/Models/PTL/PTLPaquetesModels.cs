using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Models.PTL;

public class PTLPaquetesModels
{
    public int PaquetesId { get; set; }
    public int LicenciaId { get; set; }
    public int AplicacionId { get; set; }
    public string? NombrePaquetes { get; set; }
    public string? DescripcionPaquetes { get; set; }
    public bool EstadoPaquetes { set; get; }
}
