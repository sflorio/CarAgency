using Domain.Models.Direcciones;
using Domain.Models.Finanzas;
using Domain.Models.Personas;
using Domain.Models.Vehiculos;
using Domain.Models;
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

        public DbSet<EstadoCivil> EstadoCiviles { get; set; }
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
    }
}
