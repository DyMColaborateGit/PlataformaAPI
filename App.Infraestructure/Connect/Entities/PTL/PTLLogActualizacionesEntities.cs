using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace App.Infraestructure.Connect.Entities.PTL;

public class PTLLogActualizacionesEntities
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public int SuscriptorVersionId { get; set; }
    public int SuscriptorId { get; set; }
    public int VersionId { get; set; }
}
