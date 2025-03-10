using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infraestructure.Connect.Entities.PTL;

public class PTLModulosAPEntities
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]

    public int ModuloId { get; set; }
    public int AplicacionId { get; set; }
    public string? NombreModulo { get; set; }
    public string? DescripcionModulo { get; set; }
    public bool EstadoModulo { set; get; }
}
