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
    public string? NombreLicencia { get; set; }
    public string? DescripcionLicencia { get; set; }
    public bool EstadoLicencia { set; get; }
    public int AplicacionId { set; get; }

}
