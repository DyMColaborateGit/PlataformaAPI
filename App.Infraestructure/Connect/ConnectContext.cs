﻿using App.Infraestructure.Connect.Entities.Share;
using App.Infraestructure.Connect.Entities.PTL;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace App.Infraestructure.Connect;

public class ConnectContext : DbContext
{
    public ConnectContext(DbContextOptions Options) : base(Options){}

    #region HELPERS
    public DbSet<Exception_LogEntities> Exception_Log { get; set; }
    #endregion

    #region PTL
    public DbSet<PTLSitiosAPEntities> PTLSitiosAP { get; set; }
    public DbSet<PTLEnlacesSTEntities> PTLEnlacesST { get; set; }
    public DbSet<PTLContenidosELEntities> PTLContenidosEL { get; set; }
    public DbSet<PTLRolesAPEntities> PTLRolesAP { get; set; }
    public DbSet<PTLUsuariosAPEntities> PTLUsuariosAP { get; set; }
    public DbSet<PTLUsuariosRolesEntities> PTLUsuariosRoles { get; set; }
    public DbSet<PTLAplicacionesEntities> PTLAplicaciones { get; set; }
    public DbSet<PTLModulosAPEntities> PTLModulosAP { get; set; }
    public DbSet<PTLVersionesAPEntities> PTLVersionesAP { get; set; }
    public DbSet<PTLHelpDeskTicketsAPEntities> PTLHelpDeskTicketsAP { get; set; }
    public DbSet<PTLRequerimientosHDEntities> PTLRequerimientosHD { get; set; }
    public DbSet<PTLSeguimientosRQEntities> PTLSeguimientosRQ { get; set; }
    public DbSet<PTLSuscriptoresAPEntities> PTLSuscriptoresAP { get; set; }
    public DbSet<PTLUsuariosSTEntities> PTLUsuariosST { get; set; }
    public DbSet<PTLConexionesBDEntities> PTLConexionesBD { get; set; }
    public DbSet<PTLEmpresasSTEntities> PTLEmpresasST { get; set; }
    public DbSet<PTLUsuariosEmpresaEntities> PTLUsuariosEmpresas {  get; set; }
    public DbSet<PTLLicenciasEntities> PTLLicencias { get; set; }
    public DbSet<PTLPaquetesEntities> PTLPaquetes { get; set; }
    public DbSet<PTLLogActualizacionesEntities> PTLLogActualizaciones { get; set; }
    public DbSet<PTLLogActividadesAPEntities> PTLLogActividadesAP { get; set; }
    public DbSet<PTLLogTransaccionesAPEntities> PTLLogTransaccionesAP { get; set; }

    #endregion

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
