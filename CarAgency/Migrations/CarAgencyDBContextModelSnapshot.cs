﻿// <auto-generated />
using System;
using CarAgency.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarAgency.Migrations
{
    [DbContext(typeof(CarAgencyDBContext))]
    partial class CarAgencyDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CarAgency.Models.Direccion", b =>
                {
                    b.Property<int>("DireccionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Calle")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CodigoPostal")
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("NumeroCalle")
                        .HasColumnType("int");

                    b.Property<int?>("PaisId")
                        .HasColumnType("int");

                    b.Property<int?>("ProvinciaId")
                        .HasColumnType("int");

                    b.HasKey("DireccionId");

                    b.HasIndex("PaisId");

                    b.HasIndex("ProvinciaId");

                    b.ToTable("Direcciones");
                });

            modelBuilder.Entity("CarAgency.Models.Direcciones.Localidad", b =>
                {
                    b.Property<int>("LocalidadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("PartidoId")
                        .HasColumnType("int");

                    b.HasKey("LocalidadId");

                    b.HasIndex("PartidoId");

                    b.ToTable("Localidades");
                });

            modelBuilder.Entity("CarAgency.Models.Finanzas.ConceptoFinanciero", b =>
                {
                    b.Property<int>("ConceptoFinancieroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreateUser")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeleteDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeleteUser")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("UpdateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdateUser")
                        .HasColumnType("datetime2");

                    b.HasKey("ConceptoFinancieroId");

                    b.ToTable("ConceptosFinancieros");
                });

            modelBuilder.Entity("CarAgency.Models.Finanzas.Cuenta", b =>
                {
                    b.Property<int>("CuentaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreateUser")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeleteDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeleteUser")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("NumeroCuenta")
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("UpdateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdateUser")
                        .HasColumnType("datetime2");

                    b.HasKey("CuentaId");

                    b.ToTable("Cuentas");
                });

            modelBuilder.Entity("CarAgency.Models.Finanzas.TipoOperacion", b =>
                {
                    b.Property<int>("TipoOperacionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreateUser")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeleteDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeleteUser")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("UpdateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdateUser")
                        .HasColumnType("datetime2");

                    b.HasKey("TipoOperacionId");

                    b.ToTable("TiposOperaciones");
                });

            modelBuilder.Entity("CarAgency.Models.Finanzas.Transaccion", b =>
                {
                    b.Property<int>("TransaccionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<int?>("ConceptoFinancieroId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreateUser")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeleteDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeleteUser")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DestinoCuentaId")
                        .HasColumnType("int");

                    b.Property<decimal>("Monto")
                        .HasColumnType("Decimal(18,2)");

                    b.Property<int?>("OrigenCuentaId")
                        .HasColumnType("int");

                    b.Property<int?>("TipoOperacionId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdateUser")
                        .HasColumnType("datetime2");

                    b.HasKey("TransaccionId");

                    b.HasIndex("ConceptoFinancieroId");

                    b.HasIndex("DestinoCuentaId");

                    b.HasIndex("OrigenCuentaId");

                    b.HasIndex("TipoOperacionId");

                    b.ToTable("Transacciones");
                });

            modelBuilder.Entity("CarAgency.Models.Pais", b =>
                {
                    b.Property<int>("PaisId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("PaisId");

                    b.ToTable("Paises");
                });

            modelBuilder.Entity("CarAgency.Models.Partido", b =>
                {
                    b.Property<int>("PartidoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("ProvinciaId")
                        .HasColumnType("int");

                    b.HasKey("PartidoId");

                    b.HasIndex("ProvinciaId");

                    b.ToTable("Partidos");
                });

            modelBuilder.Entity("CarAgency.Models.Personas.EstadoCivil", b =>
                {
                    b.Property<int>("EstadoCivilId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("EstadoCivilId");

                    b.ToTable("EstadoCiviles");
                });

            modelBuilder.Entity("CarAgency.Models.Personas.Persona", b =>
                {
                    b.Property<int>("PersonaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CUIL")
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("CreateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreateUser")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeleteDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeleteUser")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DireccionId")
                        .HasColumnType("int");

                    b.Property<int?>("EstadoCivilId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<int?>("NacionalidadPaisId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NumeroDocumento")
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("TipoDocumentoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdateUser")
                        .HasColumnType("datetime2");

                    b.HasKey("PersonaId");

                    b.HasIndex("DireccionId");

                    b.HasIndex("EstadoCivilId");

                    b.HasIndex("NacionalidadPaisId");

                    b.HasIndex("TipoDocumentoId");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("CarAgency.Models.Personas.TipoDocumento", b =>
                {
                    b.Property<int>("TipoDocumentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("TipoDocumentoId");

                    b.ToTable("TipoDocumentos");
                });

            modelBuilder.Entity("CarAgency.Models.Personas.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreateUser")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeleteDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeleteUser")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdateUser")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("CarAgency.Models.Provincia", b =>
                {
                    b.Property<int>("ProvinciaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("PaisId")
                        .HasColumnType("int");

                    b.HasKey("ProvinciaId");

                    b.HasIndex("PaisId");

                    b.ToTable("Provincias");
                });

            modelBuilder.Entity("CarAgency.Models.RevisionTecnica", b =>
                {
                    b.Property<int>("RevisionTecnicaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreateUser")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeleteDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeleteUser")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdateUser")
                        .HasColumnType("datetime2");

                    b.HasKey("RevisionTecnicaId");

                    b.ToTable("RevisionesTecnicas");
                });

            modelBuilder.Entity("CarAgency.Models.RevisionTecnicaConcepto", b =>
                {
                    b.Property<int>("RevisionTecnicaConceptoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreateUser")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeleteDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeleteUser")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TipoRevisionTecnicaConceptoTipoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdateUser")
                        .HasColumnType("datetime2");

                    b.HasKey("RevisionTecnicaConceptoId");

                    b.HasIndex("TipoRevisionTecnicaConceptoTipoId");

                    b.ToTable("RevisionTecnicaConceptos");
                });

            modelBuilder.Entity("CarAgency.Models.RevisionTecnicaConceptoTipo", b =>
                {
                    b.Property<int>("RevisionTecnicaConceptoTipoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreateUser")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeleteDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeleteUser")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("UpdateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdateUser")
                        .HasColumnType("datetime2");

                    b.HasKey("RevisionTecnicaConceptoTipoId");

                    b.ToTable("RevisionTecnicaConceptoTipos");
                });

            modelBuilder.Entity("CarAgency.Models.Vehiculos.Marca", b =>
                {
                    b.Property<int>("MarcaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("MarcaId");

                    b.ToTable("Marcas");
                });

            modelBuilder.Entity("CarAgency.Models.Vehiculos.Modelo", b =>
                {
                    b.Property<int>("ModeloId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("MarcaId")
                        .HasColumnType("int");

                    b.HasKey("ModeloId");

                    b.HasIndex("MarcaId");

                    b.ToTable("Modelos");
                });

            modelBuilder.Entity("CarAgency.Models.Vehiculos.Procedencia", b =>
                {
                    b.Property<int>("ProcedenciaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ProcedenciaId");

                    b.ToTable("Procedencias");
                });

            modelBuilder.Entity("CarAgency.Models.Vehiculos.TipoVehiculo", b =>
                {
                    b.Property<int>("TipoVehiculoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("TipoVehiculoId");

                    b.ToTable("TipoVehiculos");
                });

            modelBuilder.Entity("CarAgency.Models.Vehiculos.Vehiculo", b =>
                {
                    b.Property<int>("VehiculoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<byte>("Ano")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("CreateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreateUser")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeleteDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeleteUser")
                        .HasColumnType("datetime2");

                    b.Property<string>("Dominio")
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("FechaAdquisicion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInscripcionInical")
                        .HasColumnType("datetime2");

                    b.Property<string>("MarcaChasis")
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("MarcaId")
                        .HasColumnType("int");

                    b.Property<string>("MarcaMotor")
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("ModeloId")
                        .HasColumnType("int");

                    b.Property<string>("NumeroChasis")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("NumeroMotor")
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("ProcedenciaId")
                        .HasColumnType("int");

                    b.Property<int?>("TipoVehiculoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdateUser")
                        .HasColumnType("datetime2");

                    b.HasKey("VehiculoId");

                    b.HasIndex("MarcaId");

                    b.HasIndex("ModeloId");

                    b.HasIndex("ProcedenciaId");

                    b.HasIndex("TipoVehiculoId");

                    b.ToTable("Vehiculos");
                });

            modelBuilder.Entity("CarAgency.Models.Direccion", b =>
                {
                    b.HasOne("CarAgency.Models.Pais", "Pais")
                        .WithMany()
                        .HasForeignKey("PaisId");

                    b.HasOne("CarAgency.Models.Provincia", "Provincia")
                        .WithMany()
                        .HasForeignKey("ProvinciaId");
                });

            modelBuilder.Entity("CarAgency.Models.Direcciones.Localidad", b =>
                {
                    b.HasOne("CarAgency.Models.Partido", "Partido")
                        .WithMany("Localidades")
                        .HasForeignKey("PartidoId");
                });

            modelBuilder.Entity("CarAgency.Models.Finanzas.Transaccion", b =>
                {
                    b.HasOne("CarAgency.Models.Finanzas.ConceptoFinanciero", "Concepto")
                        .WithMany()
                        .HasForeignKey("ConceptoFinancieroId");

                    b.HasOne("CarAgency.Models.Finanzas.Cuenta", "Destino")
                        .WithMany()
                        .HasForeignKey("DestinoCuentaId");

                    b.HasOne("CarAgency.Models.Finanzas.Cuenta", "Origen")
                        .WithMany()
                        .HasForeignKey("OrigenCuentaId");

                    b.HasOne("CarAgency.Models.Finanzas.TipoOperacion", "TipoOperacion")
                        .WithMany()
                        .HasForeignKey("TipoOperacionId");
                });

            modelBuilder.Entity("CarAgency.Models.Partido", b =>
                {
                    b.HasOne("CarAgency.Models.Provincia", null)
                        .WithMany("Partidos")
                        .HasForeignKey("ProvinciaId");
                });

            modelBuilder.Entity("CarAgency.Models.Personas.Persona", b =>
                {
                    b.HasOne("CarAgency.Models.Direccion", "Direccion")
                        .WithMany()
                        .HasForeignKey("DireccionId");

                    b.HasOne("CarAgency.Models.Personas.EstadoCivil", "EstadoCivil")
                        .WithMany()
                        .HasForeignKey("EstadoCivilId");

                    b.HasOne("CarAgency.Models.Pais", "Nacionalidad")
                        .WithMany()
                        .HasForeignKey("NacionalidadPaisId");

                    b.HasOne("CarAgency.Models.Personas.TipoDocumento", "TipoDocumento")
                        .WithMany()
                        .HasForeignKey("TipoDocumentoId");
                });

            modelBuilder.Entity("CarAgency.Models.Provincia", b =>
                {
                    b.HasOne("CarAgency.Models.Pais", "Pais")
                        .WithMany("Provincias")
                        .HasForeignKey("PaisId");
                });

            modelBuilder.Entity("CarAgency.Models.RevisionTecnicaConcepto", b =>
                {
                    b.HasOne("CarAgency.Models.RevisionTecnicaConceptoTipo", "Tipo")
                        .WithMany()
                        .HasForeignKey("TipoRevisionTecnicaConceptoTipoId");
                });

            modelBuilder.Entity("CarAgency.Models.Vehiculos.Modelo", b =>
                {
                    b.HasOne("CarAgency.Models.Vehiculos.Marca", null)
                        .WithMany("Modelos")
                        .HasForeignKey("MarcaId");
                });

            modelBuilder.Entity("CarAgency.Models.Vehiculos.Vehiculo", b =>
                {
                    b.HasOne("CarAgency.Models.Vehiculos.Marca", "Marca")
                        .WithMany()
                        .HasForeignKey("MarcaId");

                    b.HasOne("CarAgency.Models.Vehiculos.Modelo", "Modelo")
                        .WithMany()
                        .HasForeignKey("ModeloId");

                    b.HasOne("CarAgency.Models.Vehiculos.Procedencia", "Procedencia")
                        .WithMany()
                        .HasForeignKey("ProcedenciaId");

                    b.HasOne("CarAgency.Models.Vehiculos.TipoVehiculo", "TipoVehiculo")
                        .WithMany()
                        .HasForeignKey("TipoVehiculoId");
                });
#pragma warning restore 612, 618
        }
    }
}
