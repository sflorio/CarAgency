using Domain.Models.Direcciones;
using Domain.Models.Finanzas;
using Domain.Models.Personas;
using Domain.Models.Vehiculos;
using Microsoft.EntityFrameworkCore;

namespace CarAgency.Data
{
    public class CarAgencyDBContext : DbContext
    {
        public CarAgencyDBContext(DbContextOptions<CarAgencyDBContext> options) : base(options) { }

        #region Vehiculos

        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Modelo> Modelos { get; set; }       
        public DbSet<Procedencia> Procedencias { get; set; }
        public DbSet<TipoVehiculo> TipoVehiculos { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }

        #endregion

        #region RevisionTecnica

        public DbSet<RevisionTecnica> RevisionesTecnicas { get; set; }
        public DbSet<RevisionTecnicaConcepto> RevisionTecnicaConceptos { get; set; }
        public DbSet<RevisionTecnicaConceptoTipo> RevisionTecnicaConceptoTipos { get; set; }

        #endregion


        #region Personas

        public DbSet<EstadoCivil> EstadosCiviles { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<TipoDocumento> TipoDocumentos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        #endregion

        #region Finanzas

        public DbSet<ConceptoFinanciero> ConceptosFinancieros { get; set; }
        public DbSet<Cuenta> Cuentas { get; set; }
        public DbSet<TipoOperacion> TiposOperaciones { get; set; }
        public DbSet<Transaccion> Transacciones { get; set; }
        public DbSet<TransaccionVehiculo> TransaccionesVehiculos { get; set; }


        #endregion

        #region Direcciones
        public DbSet<Direccion> Direcciones { get; set; }
        public DbSet<Localidad> Localidades { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Partido> Partidos { get; set; }
        public DbSet<Provincia> Provincias { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            //modelBuilder.Entity<EstadoCivil>().HasData(
            //    new EstadoCivil { EstadoCivilId = 1, Descripcion ="Soltero"},
            //    new EstadoCivil { EstadoCivilId = 2, Descripcion = "Casado" },
            //    new EstadoCivil { EstadoCivilId = 3, Descripcion = "Viudo" },
            //    new EstadoCivil { EstadoCivilId = 4, Descripcion = "Divorciado" }
            //);

            //modelBuilder.Entity<ConceptoFinanciero>().HasData(
            //    new ConceptoFinanciero {ConceptoFinancieroId = 1, Descripcion="Debito"  },
            //    new ConceptoFinanciero { ConceptoFinancieroId = 2, Descripcion = "Credito" }
            //);

        }
    }
}
