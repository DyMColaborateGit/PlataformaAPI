using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace App.Infraestructure.Connect.Entities.PTL;

public class PTLEmpresasSTEntities
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public int EmpresaId { get; set; }
    public int SuscriptorId { get; set; }
    public string? NombreEmpresa { get; set; }
    public string? DescripcionEmpresa { get; set; }
    public bool EstadoEmpresa { set; get; }
}
