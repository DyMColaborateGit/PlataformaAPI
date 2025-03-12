using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace App.Infraestructure.Connect.Entities.PTL;

public class PTLRolesAPEntities
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]

    public int RolId { get; set; }
    public int AplicacionId { get; set; }
    public string? NombreRol { get; set; }
    public string? DescripcionRol { get; set; }
    public bool EstadoRol { set; get; }
}

