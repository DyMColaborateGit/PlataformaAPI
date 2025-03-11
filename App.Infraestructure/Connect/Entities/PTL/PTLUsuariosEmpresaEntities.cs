using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace App.Infraestructure.Connect.Entities.PTL;

public class PTLUsuariosEmpresaEntities
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public int UsuarioEmpresaId { get; set; }
    public int UsuarioId { get; set; }
    public int EmpresaId { get; set; }
}
