using Domain.Models.Direcciones;
using Domain.Models.Finanzas;
using Domain.Models.Personas;
using Domain.Models.Vehiculos;
using Microsoft.EntityFrameworkCore;
using System;
using Domain.Models;
using Microsoft.Extensions.Configuration;
using CarAgency.Data.Seeds;

namespace CarAgency.Data
{
    public class CarAgencyDBContext : DbContext
    {
        public CarAgencyDBContext(DbContextOptions<CarAgencyDBContext> options) : base(options) {
        }

        #region Vehiculos

        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Modelo> Modelos { get; set; }       
        public DbSet<Procedencia> Procedencias { get; set; }
        public DbSet<TipoVehiculo> TipoVehiculos { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }

        #region RevisionTecnica

        public DbSet<RevisionTecnica> RevisionesTecnicas { get; set; }
        public DbSet<RevisionTecnicaConcepto> RevisionTecnicaConceptos { get; set; }
        public DbSet<RevisionTecnicaConceptoTipo> RevisionTecnicaConceptoTipos { get; set; }

        #endregion

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

            //var oSeedDirecciones = new SeedDirecciones();

            //var oSeedsProvincia = oSeedDirecciones.GetProvinciasSeeds();
            //modelBuilder.Entity<Provincia>().HasData(oSeedsProvincia);
            modelBuilder.Entity<Pais>().HasData(
                    new Pais { Descripcion = "Argentina", PaisId = 1 }
                );

            //modelBuilder.Entity<Localidad>().HasData(
            //    new Localidad { LocalidadId = 1, Descripcion = "Florida" },
            //    new Localidad { LocalidadId = 2, Descripcion = "Villa Adelina" }
            //);

            //modelBuilder.Entity<Partido>().HasData(
            //    new Partido { Descripcion = "Vicente Lopez", PartidoId = 1 },
            //    new Partido { Descripcion = "San Isidro", PartidoId = 2 }
            //    );

            //modelBuilder.Entity<Provincia>().HasData(
            //        new Provincia { Descripcion = "Buenos Aires", ProvinciaId = 1 }
            //    );

            //modelBuilder

            modelBuilder.Entity<TipoDocumento>().HasData(
                new TipoDocumento { Descripcion = "DNI" , TipoDocumentoId = 1 }
            );

            modelBuilder.Entity<TipoVehiculo>().HasData(
                new TipoVehiculo { Descripcion = "Sedan 4 puertas", TipoVehiculoId  = 1  },
                new TipoVehiculo { Descripcion = "Sedan 5 puertas", TipoVehiculoId = 2 }
            );

            //modelBuilder.Entity<EstadoCivil>().Property(e => e.CreateDateTime).HasDefaultValue(DateTime.Today);

            modelBuilder.Entity<EstadoCivil>().HasData(
                new EstadoCivil { EstadoCivilId = 1, Descripcion = "Soltero", Active = true, CreateDateTime = DateTime.Now, CreateUser = "migration" },
                new EstadoCivil { EstadoCivilId = 2, Descripcion = "Casado", Active = true, CreateDateTime = DateTime.Now, CreateUser = "migration" },
                new EstadoCivil { EstadoCivilId = 3, Descripcion = "Viudo", Active = true, CreateDateTime = DateTime.Now, CreateUser = "migration" },
                new EstadoCivil { EstadoCivilId = 4, Descripcion = "Divorciado", Active = true, CreateDateTime = DateTime.Now, CreateUser = "migration" }
            );

            modelBuilder.Entity<TipoOperacion>().HasData(
                new TipoOperacion { TipoOperacionId = 1 , Descripcion = "Debito" , Active = true, CreateDateTime = DateTime.Now, CreateUser = "migration" },
                new TipoOperacion { TipoOperacionId = 2, Descripcion = "Credito", Active = true, CreateDateTime = DateTime.Now, CreateUser = "migration" }
            );
        }            

    }
}
