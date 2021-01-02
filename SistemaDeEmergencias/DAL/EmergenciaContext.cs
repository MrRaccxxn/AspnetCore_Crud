using SistemaDeEmergencias.Models;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SistemaDeEmergencias.DAL
{
    public class EmergenciaContext  : DbContext
    {
        public EmergenciaContext() : base("EmergenciaContext")
        {
        }

        public DbSet<DetalleEmergencia> DetallesEmergencia { get; set; }
        public DbSet<Dotacion> Dotaciones { get; set; }
        public DbSet<Emergencia> Emergencias { get; set; }
        public DbSet<RolEmergencia> RolesEmergencia { get; set; }
        public DbSet<TipoEmergencia> TiposEmergencia { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<Voluntario> Voluntarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}