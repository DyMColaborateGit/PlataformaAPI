using App.Infraestructure.Connect.Entities.Share;
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
    public DbSet<PTLSitiosEntities> PTLSitios { get; set; }
    public DbSet<PTLEnlacesSTEntities> PTLEnlacesST { get; set; }
    public DbSet<PTLContentsELEntities> PTLContentsEL { get; set; }
    public DbSet<PTLRolesEntities> PTLRoles { get; set; }
    public DbSet<PTLUsuariosEntities> PTLUsuarios { get; set; }
    public DbSet<PTLUsuariosRolesEntities> PTLUsuariosRoles { get; set; }
    public DbSet<PTLAplicacionAPEntities> PTLAplicacionesAP { get; set; }
    public DbSet<PTLModulosAPEntities> PTLModuloAP { get; set; }
    public DbSet<PTLVersionesAPEntities> PTLVersionesAP { get; set; }
    public DbSet<PTLHelpDeskTicketAPEntities> PTLHelpDeskTicketAP { get; set; }
    public DbSet<PTLRequerimientoHDEntities> PTLRequerimientoHD { get; set; }



    #endregion

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
