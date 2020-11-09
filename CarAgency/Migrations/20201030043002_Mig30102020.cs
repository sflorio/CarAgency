using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarAgency.Migrations
{
    public partial class Mig30102020 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UpdateUser",
                table: "Vehiculos",
                type: "nvarchar(20)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "DeleteUser",
                table: "Vehiculos",
                type: "nvarchar(20)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "CreateUser",
                table: "Vehiculos",
                type: "nvarchar(20)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "UpdateUser",
                table: "Usuarios",
                type: "nvarchar(20)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "DeleteUser",
                table: "Usuarios",
                type: "nvarchar(20)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "CreateUser",
                table: "Usuarios",
                type: "nvarchar(20)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "UpdateUser",
                table: "Transacciones",
                type: "nvarchar(20)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "DeleteUser",
                table: "Transacciones",
                type: "nvarchar(20)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "CreateUser",
                table: "Transacciones",
                type: "nvarchar(20)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "UpdateUser",
                table: "TiposOperaciones",
                type: "nvarchar(20)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "DeleteUser",
                table: "TiposOperaciones",
                type: "nvarchar(20)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "CreateUser",
                table: "TiposOperaciones",
                type: "nvarchar(20)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "UpdateUser",
                table: "RevisionTecnicaConceptoTipos",
                type: "nvarchar(20)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "DeleteUser",
                table: "RevisionTecnicaConceptoTipos",
                type: "nvarchar(20)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "CreateUser",
                table: "RevisionTecnicaConceptoTipos",
                type: "nvarchar(20)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "UpdateUser",
                table: "RevisionTecnicaConceptos",
                type: "nvarchar(20)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "DeleteUser",
                table: "RevisionTecnicaConceptos",
                type: "nvarchar(20)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "CreateUser",
                table: "RevisionTecnicaConceptos",
                type: "nvarchar(20)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "UpdateUser",
                table: "RevisionesTecnicas",
                type: "nvarchar(20)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "DeleteUser",
                table: "RevisionesTecnicas",
                type: "nvarchar(20)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "CreateUser",
                table: "RevisionesTecnicas",
                type: "nvarchar(20)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "UpdateUser",
                table: "Personas",
                type: "nvarchar(20)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "DeleteUser",
                table: "Personas",
                type: "nvarchar(20)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "CreateUser",
                table: "Personas",
                type: "nvarchar(20)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "UpdateUser",
                table: "Cuentas",
                type: "nvarchar(20)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "DeleteUser",
                table: "Cuentas",
                type: "nvarchar(20)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "CreateUser",
                table: "Cuentas",
                type: "nvarchar(20)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "UpdateUser",
                table: "ConceptosFinancieros",
                type: "nvarchar(20)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "DeleteUser",
                table: "ConceptosFinancieros",
                type: "nvarchar(20)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "CreateUser",
                table: "ConceptosFinancieros",
                type: "nvarchar(20)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateUser",
                table: "Vehiculos",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteUser",
                table: "Vehiculos",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateUser",
                table: "Vehiculos",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateUser",
                table: "Usuarios",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteUser",
                table: "Usuarios",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateUser",
                table: "Usuarios",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateUser",
                table: "Transacciones",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteUser",
                table: "Transacciones",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateUser",
                table: "Transacciones",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateUser",
                table: "TiposOperaciones",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteUser",
                table: "TiposOperaciones",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateUser",
                table: "TiposOperaciones",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateUser",
                table: "RevisionTecnicaConceptoTipos",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteUser",
                table: "RevisionTecnicaConceptoTipos",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateUser",
                table: "RevisionTecnicaConceptoTipos",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateUser",
                table: "RevisionTecnicaConceptos",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteUser",
                table: "RevisionTecnicaConceptos",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateUser",
                table: "RevisionTecnicaConceptos",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateUser",
                table: "RevisionesTecnicas",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteUser",
                table: "RevisionesTecnicas",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateUser",
                table: "RevisionesTecnicas",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateUser",
                table: "Personas",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteUser",
                table: "Personas",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateUser",
                table: "Personas",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateUser",
                table: "Cuentas",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteUser",
                table: "Cuentas",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateUser",
                table: "Cuentas",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateUser",
                table: "ConceptosFinancieros",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteUser",
                table: "ConceptosFinancieros",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateUser",
                table: "ConceptosFinancieros",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldNullable: true);
        }
    }
}
