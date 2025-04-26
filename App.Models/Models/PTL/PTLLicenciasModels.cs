using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Models.PTL;

public class PTLLicenciasModels
{
    public int LicenciaId { get; set; }
    public int SuscriptorId { get; set; }
    public int AplicacionId { set; get; }
    public string? NombreLicencia { get; set; }
    public string? DescripcionLicencia { get; set; }
    public bool EstadoLicencia { set; get; }
    public DateTime FechaCreacion { set; get; }
    public DateTime FechaVencimiento { set; get; }
}
