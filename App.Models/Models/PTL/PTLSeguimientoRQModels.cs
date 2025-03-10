using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Models.PTL
{
    public class PTLSeguimientoRQModels
    {
        public int SeguimientoId { get; set; }
        public int RequerimientoId { get; set; }
        public string? NombreSeguimiento { get; set; }
        public string? DescripcionSeguimiento { get; set; }
        public bool EstadoSeguimiento { set; get; }
    }
}
