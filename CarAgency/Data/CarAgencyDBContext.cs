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
            //modelBuilder.Entity<Pais>().HasData(
            //    new Pais { Descripcion = "Argentina", PaisId = 1 }
            //);

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

            //Property(e => e.Marca.MarcaId).HasColumnName("MarcaId");
            //modelBuilder.Entity<Vehiculo>().Property(e => e.Modelo.ModeloId).HasColumnName("ModeloId");
            //modelBuilder.Entity<Vehiculo>().Property(e => e.Procedencia.ProcedenciaId).HasColumnName("ProcedenciaId");

            //modelBuilder.Entity<Localidad>().HasData(
            //    new Localidad { LocalidadId = 1, Descripcion = "Florida" },
            //    new Localidad { LocalidadId = 2, Descripcion = "Villa Adelina" }
            //);

            //modelBuilder.Entity<Partido>().HasData(
            //    new Partido { Descripcion = "Vicente Lopez", PartidoId = 1 },
            //    new Partido { Descripcion = "San Isidro", PartidoId = 2 }
            //    );


            //modelBuilder.Entity<Provincia>().HasData(
            //    new Provincia { Descripcion = "Misiones", ProvinciaId = 1, PaisId = 1 },
            //    new Provincia { Descripcion = "San Luis", ProvinciaId = 2, PaisId = 1 },
            //    new Provincia { Descripcion = "San Juan", ProvinciaId = 3, PaisId = 1 },
            //    new Provincia { Descripcion = "Entre Ríos", ProvinciaId = 4, PaisId = 1 },
            //    new Provincia { Descripcion = "Santa Cruz", ProvinciaId = 5, PaisId = 1 },
            //    new Provincia { Descripcion = "Río Negro", ProvinciaId = 6, PaisId = 1 },
            //    new Provincia { Descripcion = "Chubut", ProvinciaId = 7, PaisId = 1 },
            //    new Provincia { Descripcion = "Córdoba", ProvinciaId = 8, PaisId = 1 },
            //    new Provincia { Descripcion = "Mendoza", ProvinciaId = 9, PaisId = 1 },
            //    new Provincia { Descripcion = "La Rioja", ProvinciaId = 10, PaisId = 1 },
            //    new Provincia { Descripcion = "Catamarca", ProvinciaId = 11, PaisId = 1 },
            //    new Provincia { Descripcion = "La Pampa", ProvinciaId = 12, PaisId = 1 },
            //    new Provincia { Descripcion = "Santiago del Estero", ProvinciaId = 13, PaisId = 1 },
            //    new Provincia { Descripcion = "Corrientes", ProvinciaId = 14, PaisId = 1 },
            //    new Provincia { Descripcion = "Santa Fe", ProvinciaId = 15, PaisId = 1 },
            //    new Provincia { Descripcion = "Tucumán", ProvinciaId = 16, PaisId = 1 },
            //    new Provincia { Descripcion = "Neuquén", ProvinciaId = 17, PaisId = 1 },
            //    new Provincia { Descripcion = "Salta", ProvinciaId = 18, PaisId = 1 },
            //    new Provincia { Descripcion = "Chaco", ProvinciaId = 19, PaisId = 1 },
            //    new Provincia { Descripcion = "Formosa", ProvinciaId = 20, PaisId = 1 },
            //    new Provincia { Descripcion = "Jujuy", ProvinciaId = 21, PaisId = 1 },
            //    new Provincia { Descripcion = "Ciudad Autónoma de Buenos Aires", ProvinciaId = 22, PaisId = 1 },
            //    new Provincia { Descripcion = "Buenos Aires", ProvinciaId = 23, PaisId = 1 },
            //    new Provincia { Descripcion = "Tierra del Fuego, Antártida e Islas del Atlántico Sur", ProvinciaId = 24, PaisId = 1 }
            //);
            ////modelBuilder

            //modelBuilder.Entity<TipoDocumento>().HasData(
            //    new TipoDocumento { Descripcion = "DNI" , TipoDocumentoId = 1 }
            //);



            //modelBuilder.Entity<EstadoCivil>().Property(e => e.CreateDateTime).HasDefaultValue(DateTime.Today);

            //modelBuilder.Entity<EstadoCivil>().HasData(
            //    new EstadoCivil { EstadoCivilId = 1, Descripcion = "Soltero", Active = true, CreateDateTime = DateTime.Now, CreateUser = "migration" },
            //    new EstadoCivil { EstadoCivilId = 2, Descripcion = "Casado", Active = true, CreateDateTime = DateTime.Now, CreateUser = "migration" },
            //    new EstadoCivil { EstadoCivilId = 3, Descripcion = "Viudo", Active = true, CreateDateTime = DateTime.Now, CreateUser = "migration" },
            //    new EstadoCivil { EstadoCivilId = 4, Descripcion = "Divorciado", Active = true, CreateDateTime = DateTime.Now, CreateUser = "migration" }
            //);

            //modelBuilder.Entity<TipoOperacion>().HasData(
            //    new TipoOperacion { TipoOperacionId = 1 , Descripcion = "Debito" , Active = true, CreateDateTime = DateTime.Now, CreateUser = "migration" },
            //    new TipoOperacion { TipoOperacionId = 2 , Descripcion = "Credito", Active = true, CreateDateTime = DateTime.Now, CreateUser = "migration" }
            //);


            //modelBuilder.Entity<Procedencia>().HasData(
            //    new Procedencia { Descripcion = "Particular", ProcedenciaId = 1 } 
            //);

            //modelBuilder.Entity<TipoVehiculo>().HasData(
            //    new TipoVehiculo { Descripcion = "CHASIS CON CABINA", TipoVehiculoId = 1 },
            //    new TipoVehiculo { Descripcion = "PICK-UP", TipoVehiculoId = 2 },
            //    new TipoVehiculo { Descripcion = "RURAL 5 PUERTAS", TipoVehiculoId = 3 },
            //    new TipoVehiculo { Descripcion = "TODO TERRENO", TipoVehiculoId = 4 },
            //    new TipoVehiculo { Descripcion = "TRACTOR C/CABINA DORMITORIO", TipoVehiculoId = 5 },
            //    new TipoVehiculo { Descripcion = "DESCAPOTABLE", TipoVehiculoId = 6 },
            //    new TipoVehiculo { Descripcion = "CICLOMOTOR", TipoVehiculoId = 7 },
            //    new TipoVehiculo { Descripcion = "FURGON", TipoVehiculoId = 8 },
            //    new TipoVehiculo { Descripcion = "MOTONETA / SCOOTER", TipoVehiculoId = 9 },
            //    new TipoVehiculo { Descripcion = "MOTOVEHICULO", TipoVehiculoId = 10 },
            //    new TipoVehiculo { Descripcion = "TRANS.DE PASAJEROS", TipoVehiculoId = 11 },
            //    new TipoVehiculo { Descripcion = "CHASIS S/CABINA", TipoVehiculoId = 12 },
            //    new TipoVehiculo { Descripcion = "SEDAN 2 PUERTAS", TipoVehiculoId = 13 },
            //    new TipoVehiculo { Descripcion = "FURGONETA", TipoVehiculoId = 14 },
            //    new TipoVehiculo { Descripcion = "RURAL 4/5 PUERTAS", TipoVehiculoId = 15 },
            //    new TipoVehiculo { Descripcion = "CAMION C/CABINA DORMITORIO", TipoVehiculoId = 16 },
            //    new TipoVehiculo { Descripcion = "MOTOCICLETA", TipoVehiculoId = 17 },
            //    new TipoVehiculo { Descripcion = "TRANSPORTE DE PASAJEROS", TipoVehiculoId = 18 },
            //    new TipoVehiculo { Descripcion = "CUATRICICLO", TipoVehiculoId = 19 },
            //    new TipoVehiculo { Descripcion = "SIN ESPECIFICACION", TipoVehiculoId = 20 },
            //    new TipoVehiculo { Descripcion = "PICK-UP CABINA SIMPLE", TipoVehiculoId = 21 },
            //    new TipoVehiculo { Descripcion = "CAMION", TipoVehiculoId = 22 },
            //    new TipoVehiculo { Descripcion = "SEDAN 5 PUERTAS", TipoVehiculoId = 23 },
            //    new TipoVehiculo { Descripcion = "CONVERTIBLE", TipoVehiculoId = 24 },
            //    new TipoVehiculo { Descripcion = "SEDAN 4 PUERTAS", TipoVehiculoId = 25 },
            //    new TipoVehiculo { Descripcion = "TRACTOR DE CARRETERA", TipoVehiculoId = 26 },
            //    new TipoVehiculo { Descripcion = "FAMILIAR", TipoVehiculoId = 27 },
            //    new TipoVehiculo { Descripcion = "SEDAN 3 PUERTAS", TipoVehiculoId = 28 },
            //    new TipoVehiculo { Descripcion = "UTILITARIO", TipoVehiculoId = 29 },
            //    new TipoVehiculo { Descripcion = "PICK-UP CABINA Y MEDIA", TipoVehiculoId = 30 },
            //    new TipoVehiculo { Descripcion = "RURAL 4 PUERTAS", TipoVehiculoId = 31 },
            //    new TipoVehiculo { Descripcion = "COUPE", TipoVehiculoId = 32 },
            //    new TipoVehiculo { Descripcion = "SCOOTER", TipoVehiculoId = 33 },
            //    new TipoVehiculo { Descripcion = "RURAL 3 PUERTAS", TipoVehiculoId = 34 },
            //    new TipoVehiculo { Descripcion = "FURGONETA O UTILITARIO", TipoVehiculoId = 35 },
            //    new TipoVehiculo { Descripcion = "ARENERO", TipoVehiculoId = 36 },
            //    new TipoVehiculo { Descripcion = "TRICICLO", TipoVehiculoId = 37 },
            //    new TipoVehiculo { Descripcion = "PICK-UP CABINA DOBLE", TipoVehiculoId = 38 },
            //    new TipoVehiculo { Descripcion = "CHASIS C/CABINA DORMITORIO", TipoVehiculoId = 39 },
            //    new TipoVehiculo { Descripcion = "CHASIS C/CABINA", TipoVehiculoId = 40 },
            //    new TipoVehiculo { Descripcion = "FURGON O UTILITARIO", TipoVehiculoId = 41 },
            //    new TipoVehiculo { Descripcion = "CHASIS SIN CABINA", TipoVehiculoId = 42 },
            //    new TipoVehiculo { Descripcion = "PICK-UP CARROZADA", TipoVehiculoId = 43 },
            //    new TipoVehiculo { Descripcion = "CHASIS CON CABINA", TipoVehiculoId = 44 },
            //    new TipoVehiculo { Descripcion = "TRACTOR C/CABINA DORMITORIO", TipoVehiculoId = 45 },
            //    new TipoVehiculo { Descripcion = "CHASIS CON CABINA DORMITORIO", TipoVehiculoId = 46 },
            //    new TipoVehiculo { Descripcion = "PICK-UP", TipoVehiculoId = 47 },
            //    new TipoVehiculo { Descripcion = "RURAL 5 PUERTAS", TipoVehiculoId = 48 },
            //    new TipoVehiculo { Descripcion = "TODO TERRENO", TipoVehiculoId = 49 },
            //    new TipoVehiculo { Descripcion = "JEEP", TipoVehiculoId = 50 },
            //    new TipoVehiculo { Descripcion = "DESCAPOTABLE", TipoVehiculoId = 51 },
            //    new TipoVehiculo { Descripcion = "CICLOMOTOR", TipoVehiculoId = 52 },
            //    new TipoVehiculo { Descripcion = "SEDAN 3 PUERTAS CON PORTON", TipoVehiculoId = 54 },
            //    new TipoVehiculo { Descripcion = "FURGON", TipoVehiculoId = 55 },
            //    new TipoVehiculo { Descripcion = "MOTONETA / SCOOTER", TipoVehiculoId = 56 },
            //    new TipoVehiculo { Descripcion = "MOTOVEHICULO", TipoVehiculoId = 57 },
            //    new TipoVehiculo { Descripcion = "TRANS.DE PASAJEROS", TipoVehiculoId = 58 },
            //    new TipoVehiculo { Descripcion = "CHASIS S/CABINA", TipoVehiculoId = 59 },
            //    new TipoVehiculo { Descripcion = "SEDAN 2 PUERTAS", TipoVehiculoId = 60 },
            //    new TipoVehiculo { Descripcion = "FURGONETA", TipoVehiculoId = 61 },
            //    new TipoVehiculo { Descripcion = "RURAL 4/5 PUERTAS", TipoVehiculoId = 62 },
            //    new TipoVehiculo { Descripcion = "DORMITORIO", TipoVehiculoId = 63 },
            //    new TipoVehiculo { Descripcion = "MOTOCICLETA", TipoVehiculoId = 64 },
            //    new TipoVehiculo { Descripcion = "PICK-UP CABINA Y MEDIA", TipoVehiculoId = 65 },
            //    new TipoVehiculo { Descripcion = "CHASIS C/CABINA DORMITORIO", TipoVehiculoId = 66 },
            //    new TipoVehiculo { Descripcion = "CUATRIC.C/DISP.ENG.", TipoVehiculoId = 67 },
            //    new TipoVehiculo { Descripcion = "CUATRICICLO", TipoVehiculoId = 68 },
            //    new TipoVehiculo { Descripcion = "SIN ESPECIFICACION", TipoVehiculoId = 69 },
            //    new TipoVehiculo { Descripcion = "TRACTOR DE CARRETERA", TipoVehiculoId = 70 },
            //    new TipoVehiculo { Descripcion = "PICK-UP CABINA SIMPLE", TipoVehiculoId = 71 },
            //    new TipoVehiculo { Descripcion = "CAMION", TipoVehiculoId = 72 },
            //    new TipoVehiculo { Descripcion = "TECTOR 240E28 PASO 4815 CHASIS C/CABINA", TipoVehiculoId = 73 },
            //    new TipoVehiculo { Descripcion = "SEDAN 5 PUERTAS", TipoVehiculoId = 74 },
            //    new TipoVehiculo { Descripcion = "CONVERTIBLE", TipoVehiculoId = 75 },
            //    new TipoVehiculo { Descripcion = "SEDAN 4 PUERTAS", TipoVehiculoId = 76 },
            //    new TipoVehiculo { Descripcion = "MINIBUS", TipoVehiculoId = 77 },
            //    new TipoVehiculo { Descripcion = "TRACTOR", TipoVehiculoId = 78 },
            //    new TipoVehiculo { Descripcion = "CARGO 1933 48 CD ST AMT CHASIS C/CABINA", TipoVehiculoId = 80 },
            //    new TipoVehiculo { Descripcion = "FAMILIAR", TipoVehiculoId = 81 },
            //    new TipoVehiculo { Descripcion = "FURGONETA O UTILITARIO", TipoVehiculoId = 82 },
            //    new TipoVehiculo { Descripcion = "SEDAN 3 PUERTAS", TipoVehiculoId = 83 },
            //    new TipoVehiculo { Descripcion = "UTILITARIO", TipoVehiculoId = 84 },
            //    new TipoVehiculo { Descripcion = "MINIBUS (O MICROOMNIBUS)", TipoVehiculoId = 85 },
            //    new TipoVehiculo { Descripcion = "TRACTOR CON CABINA DORMITORIO", TipoVehiculoId = 86 },
            //    new TipoVehiculo { Descripcion = "CAMION C/CABINA DORMITORIO", TipoVehiculoId = 87 },
            //    new TipoVehiculo { Descripcion = "PICK UP", TipoVehiculoId = 88 },
            //    new TipoVehiculo { Descripcion = "RURAL 4 PUERTAS", TipoVehiculoId = 89 },
            //    new TipoVehiculo { Descripcion = "CARGO 1729 6X2 53 CD MT CHASIS C/CABINA", TipoVehiculoId = 90 },
            //    new TipoVehiculo { Descripcion = "COUPE", TipoVehiculoId = 91 },
            //    new TipoVehiculo { Descripcion = "SCOOTER", TipoVehiculoId = 92 },
            //    new TipoVehiculo { Descripcion = "RURAL 3 PUERTAS", TipoVehiculoId = 93 },
            //    new TipoVehiculo { Descripcion = "CHASIS CON CABINA DOBLE", TipoVehiculoId = 94 },
            //    new TipoVehiculo { Descripcion = "CAMION GRUA", TipoVehiculoId = 95 },
            //    new TipoVehiculo { Descripcion = "ARENERO", TipoVehiculoId = 96 },
            //    new TipoVehiculo { Descripcion = "TRICICLO DE CARGA", TipoVehiculoId = 97 },
            //    new TipoVehiculo { Descripcion = "TRICICLO", TipoVehiculoId = 98 },
            //    new TipoVehiculo { Descripcion = "PICK-UP CABINA DOBLE", TipoVehiculoId = 99 },
            //    new TipoVehiculo { Descripcion = "TRANSPORTE DE PASAJEROS", TipoVehiculoId = 100 },
            //    new TipoVehiculo { Descripcion = "CHASIS C/CABINA", TipoVehiculoId = 101 },
            //    new TipoVehiculo { Descripcion = "FURGON O UTILITARIO", TipoVehiculoId = 102 },
            //    new TipoVehiculo { Descripcion = "CHASIS SIN CABINA", TipoVehiculoId = 103 },
            //    new TipoVehiculo { Descripcion = "PICK-UP CARROZADA", TipoVehiculoId = 104 },
            //    new TipoVehiculo { Descripcion = "MIDIBUS", TipoVehiculoId = 105 },
            //    new TipoVehiculo { Descripcion = "OMNIBUS", TipoVehiculoId = 106 }
            //);

            //modelBuilder.Entity<Marca>().HasData(
            //    new Marca { Descripcion = "GEELY", MarcaId = 1 },
            //    new Marca { Descripcion = "CADILLAC", MarcaId = 2 },
            //    new Marca { Descripcion = "AIXAM", MarcaId = 3 },
            //    new Marca { Descripcion = "DACIA", MarcaId = 4 },
            //    new Marca { Descripcion = "HARLEY DAVIDSON", MarcaId = 5 },
            //    new Marca { Descripcion = "CAN-AM", MarcaId = 6 },
            //    new Marca { Descripcion = "GENERAL MOTORS", MarcaId = 7 },
            //    new Marca { Descripcion = "3-STAR", MarcaId = 8 },
            //    new Marca { Descripcion = "BRAVA", MarcaId = 9 },
            //    new Marca { Descripcion = "BETAMOTOR", MarcaId = 10 },
            //    new Marca { Descripcion = "CORVEN", MarcaId = 11 },
            //    new Marca { Descripcion = "ASIA", MarcaId = 12 },
            //    new Marca { Descripcion = "CHERY", MarcaId = 13 },
            //    new Marca { Descripcion = "FERRARI", MarcaId = 14 },
            //    new Marca { Descripcion = "APPIA", MarcaId = 15 },
            //    new Marca { Descripcion = "GREAT WALL", MarcaId = 16 },
            //    new Marca { Descripcion = "FIAT IVECO", MarcaId = 17 },
            //    new Marca { Descripcion = "GAZ", MarcaId = 18 },
            //    new Marca { Descripcion = "GILERA", MarcaId = 19 },
            //    new Marca { Descripcion = "FOTON", MarcaId = 20 },
            //    new Marca { Descripcion = "AGRALE", MarcaId = 21 },
            //    new Marca { Descripcion = "DUCATI", MarcaId = 22 },
            //    new Marca { Descripcion = "CERRO", MarcaId = 23 },
            //    new Marca { Descripcion = "DODGE", MarcaId = 24 },
            //    new Marca { Descripcion = "GALLOPER", MarcaId = 25 },
            //    new Marca { Descripcion = "GMC", MarcaId = 26 },
            //    new Marca { Descripcion = "GAC GONOW", MarcaId = 27 },
            //    new Marca { Descripcion = "CHANGAN", MarcaId = 28 },
            //    new Marca { Descripcion = "DA DALT", MarcaId = 29 },
            //    new Marca { Descripcion = "GAMMA", MarcaId = 30 },
            //    new Marca { Descripcion = "BENELLI", MarcaId = 31 },
            //    new Marca { Descripcion = "BLACKSTONE", MarcaId = 32 },
            //    new Marca { Descripcion = "DEUTZ", MarcaId = 33 },
            //    new Marca { Descripcion = "BAIC", MarcaId = 34 },
            //    new Marca { Descripcion = "DEUTZ-AGRALE", MarcaId = 35 },
            //    new Marca { Descripcion = "EUROMOT", MarcaId = 36 },
            //    new Marca { Descripcion = "GUERRERO", MarcaId = 37 },
            //    new Marca { Descripcion = "ACURA", MarcaId = 38 },
            //    new Marca { Descripcion = "DIMEX", MarcaId = 39 },
            //    new Marca { Descripcion = "GARELLI SAHEL", MarcaId = 40 },
            //    new Marca { Descripcion = "BMW", MarcaId = 41 },
            //    new Marca { Descripcion = "DAELIM", MarcaId = 42 },
            //    new Marca { Descripcion = "GEO", MarcaId = 43 },
            //    new Marca { Descripcion = "DFSK", MarcaId = 44 },
            //    new Marca { Descripcion = "GAF", MarcaId = 45 },
            //    new Marca { Descripcion = "BAJAJ", MarcaId = 46 },
            //    new Marca { Descripcion = "DAIMLER BENZ", MarcaId = 47 },
            //    new Marca { Descripcion = "CHEVROLET", MarcaId = 48 },
            //    new Marca { Descripcion = "CITROEN", MarcaId = 49 },
            //    new Marca { Descripcion = "BELAVTOMAZ", MarcaId = 50 },
            //    new Marca { Descripcion = "APRILIA", MarcaId = 51 },
            //    new Marca { Descripcion = "BLAC", MarcaId = 52 },
            //    new Marca { Descripcion = "ELITE", MarcaId = 53 },
            //    new Marca { Descripcion = "FIAT", MarcaId = 54 },
            //    new Marca { Descripcion = "DAIHATSU", MarcaId = 55 },
            //    new Marca { Descripcion = "DEUTZ AGRALE", MarcaId = 56 },
            //    new Marca { Descripcion = "FERESA", MarcaId = 57 },
            //    new Marca { Descripcion = "CHRYSLER", MarcaId = 58 },
            //    new Marca { Descripcion = "CF MOTO", MarcaId = 59 },
            //    new Marca { Descripcion = "BETA", MarcaId = 60 },
            //    new Marca { Descripcion = "DINA", MarcaId = 61 },
            //    new Marca { Descripcion = "ARO", MarcaId = 62 },
            //    new Marca { Descripcion = "CFMOTO", MarcaId = 63 },
            //    new Marca { Descripcion = "ARCTIC CAT", MarcaId = 64 },
            //    new Marca { Descripcion = "DAEWOO", MarcaId = 65 },
            //    new Marca { Descripcion = "ALFA ROMEO", MarcaId = 66 },
            //    new Marca { Descripcion = "FORD", MarcaId = 67 },
            //    new Marca { Descripcion = "DFM", MarcaId = 68 },
            //    new Marca { Descripcion = "GHIGGERI", MarcaId = 69 },
            //    new Marca { Descripcion = "DS", MarcaId = 70 },
            //    new Marca { Descripcion = "AUDI", MarcaId = 71 }
            //);




        }            

    }
}
