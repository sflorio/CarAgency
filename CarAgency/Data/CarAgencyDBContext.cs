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

            modelBuilder.Entity<Vehiculo>().HasOne(e => e.Marca);
            modelBuilder.Entity<Vehiculo>().Navigation(b => b.Marca).UsePropertyAccessMode(PropertyAccessMode.Property);


            modelBuilder.Entity<Vehiculo>().HasOne(e => e.Modelo);
            modelBuilder.Entity<Vehiculo>().Navigation(b => b.Modelo).UsePropertyAccessMode(PropertyAccessMode.Property);
            modelBuilder.Entity<Vehiculo>().HasOne(e => e.Procedencia);
            modelBuilder.Entity<Vehiculo>().Navigation(b => b.Procedencia).UsePropertyAccessMode(PropertyAccessMode.Property);


            modelBuilder.Entity<Vehiculo>().HasOne(e => e.Titular);
            modelBuilder.Entity<Vehiculo>().Navigation(b => b.Titular).UsePropertyAccessMode(PropertyAccessMode.Property);


            modelBuilder.Entity<Persona>().HasOne(e => e.Direccion);
            modelBuilder.Entity<Persona>().Navigation(b => b.Direccion).UsePropertyAccessMode(PropertyAccessMode.Property);

            modelBuilder.Entity<Direccion>().HasOne(e => e.Pais);
            modelBuilder.Entity<Direccion>().Navigation(b => b.Pais).UsePropertyAccessMode(PropertyAccessMode.Property);

            modelBuilder.Entity<Direccion>().HasOne(e => e.Provincia);
            modelBuilder.Entity<Direccion>().Navigation(b => b.Provincia).UsePropertyAccessMode(PropertyAccessMode.Property);

            modelBuilder.Entity<Direccion>().HasOne(e => e.Partido);
            modelBuilder.Entity<Direccion>().Navigation(b => b.Partido).UsePropertyAccessMode(PropertyAccessMode.Property);

            modelBuilder.Entity<Direccion>().HasOne(e => e.Localidad);
            modelBuilder.Entity<Direccion>().Navigation(b => b.Localidad).UsePropertyAccessMode(PropertyAccessMode.Property);            
        }            

    }
}
