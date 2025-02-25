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
    public DbSet<PTLContenidosELEntities> PTLContenidosEL { get; set; }
    public DbSet<PTLEnlacesSTEntities> PTLEnlacesST { get; set; }
    public DbSet<PTLSitiosEntities> PTLSitios { get; set; }
    #endregion

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
