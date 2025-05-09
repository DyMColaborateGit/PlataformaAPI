﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Infraestructure.Connect.Entities.PTL;

public class PTLSitiosAPEntities
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public int SitioId { get; set; }
    public string? NombreSitio { get; set; }
    public string? DescripcionSitio { get; set; }
    public string? UrlSitio { get; set; }
    public bool EstadoSitio { get; set; }
    public int AplicacionId { get; set; }
    public int PuertoSitio { get; set; }

}
