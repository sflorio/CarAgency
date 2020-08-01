using Microsoft.EntityFrameworkCore.Migrations;

namespace CarAgency.Migrations
{
    public partial class Migration2020081_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nvarchar(20)",
                table: "Vehiculos",
                newName: "Dominio");

            migrationBuilder.RenameColumn(
                name: "tinyint",
                table: "Vehiculos",
                newName: "Ano");

            migrationBuilder.RenameColumn(
                name: "varchar(20)",
                table: "Usuarios",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "Decimal(18,2)",
                table: "Transacciones",
                newName: "Monto");

            migrationBuilder.RenameColumn(
                name: "nvarchar(20)",
                table: "TipoVehiculos",
                newName: "Descripcion");

            migrationBuilder.RenameColumn(
                name: "nvarchar(20)",
                table: "TiposOperaciones",
                newName: "Descripcion");

            migrationBuilder.RenameColumn(
                name: "nvarcahr(20)",
                table: "TipoDocumentos",
                newName: "Descripcion");

            migrationBuilder.RenameColumn(
                name: "nvachar(50)",
                table: "RevisionTecnicaConceptoTipos",
                newName: "Descripcion");

            migrationBuilder.RenameColumn(
                name: "nvachar(50)",
                table: "RevisionTecnicaConceptos",
                newName: "Descripcion");

            migrationBuilder.RenameColumn(
                name: "nvarchar(100)",
                table: "Provincias",
                newName: "Descripcion");

            migrationBuilder.RenameColumn(
                name: "nvarchar(20)",
                table: "Procedencias",
                newName: "Descripcion");

            migrationBuilder.RenameColumn(
                name: "nvarchar(20)",
                table: "Personas",
                newName: "CUIL");

            migrationBuilder.RenameColumn(
                name: "nvarchar(100)",
                table: "Personas",
                newName: "Apellido");

            migrationBuilder.RenameColumn(
                name: "nvarchar(100)",
                table: "Partidos",
                newName: "Descripcion");

            migrationBuilder.RenameColumn(
                name: "nvarchar(100)",
                table: "Paises",
                newName: "Descripcion");

            migrationBuilder.RenameColumn(
                name: "nvarchar(20)",
                table: "EstadoCiviles",
                newName: "Descripcion");

            migrationBuilder.RenameColumn(
                name: "nvarchar(10)",
                table: "Direcciones",
                newName: "CodigoPostal");

            migrationBuilder.RenameColumn(
                name: "nvarchar(100)",
                table: "Direcciones",
                newName: "Calle");

            migrationBuilder.RenameColumn(
                name: "nvarchar(50)",
                table: "Cuentas",
                newName: "NumeroCuenta");

            migrationBuilder.RenameColumn(
                name: "nvarchar(200)",
                table: "Cuentas",
                newName: "Descripcion");

            migrationBuilder.RenameColumn(
                name: "nvarchar(200)",
                table: "ConceptosFinancieros",
                newName: "Descripcion");

            migrationBuilder.AlterColumn<string>(
                name: "Dominio",
                table: "Vehiculos",
                type: "nvarchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "Ano",
                table: "Vehiculos",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AddColumn<string>(
                name: "MarcaChasis",
                table: "Vehiculos",
                type: "nvarchar(20)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MarcaMotor",
                table: "Vehiculos",
                type: "nvarchar(20)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NumeroChasis",
                table: "Vehiculos",
                type: "nvarchar(20)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NumeroMotor",
                table: "Vehiculos",
                type: "nvarchar(20)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Usuarios",
                type: "nvarchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Monto",
                table: "Transacciones",
                type: "Decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "TipoVehiculos",
                type: "nvarchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "TiposOperaciones",
                type: "nvarchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "TipoDocumentos",
                type: "nvarchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "RevisionTecnicaConceptoTipos",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "RevisionTecnicaConceptos",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Provincias",
                type: "nvarchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Procedencias",
                type: "nvarchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CUIL",
                table: "Personas",
                type: "nvarchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Apellido",
                table: "Personas",
                type: "nvarchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Personas",
                type: "nvarchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NumeroDocumento",
                table: "Personas",
                type: "nvarchar(20)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Partidos",
                type: "nvarchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Paises",
                type: "nvarchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Localidades",
                type: "nvarchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "EstadoCiviles",
                type: "nvarchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CodigoPostal",
                table: "Direcciones",
                type: "nvarchar(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Calle",
                table: "Direcciones",
                type: "nvarchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NumeroCuenta",
                table: "Cuentas",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Cuentas",
                type: "nvarchar(200)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "ConceptosFinancieros",
                type: "nvarchar(200)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MarcaChasis",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "MarcaMotor",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "NumeroChasis",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "NumeroMotor",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "NumeroDocumento",
                table: "Personas");

            migrationBuilder.RenameColumn(
                name: "Dominio",
                table: "Vehiculos",
                newName: "nvarchar(20)");

            migrationBuilder.RenameColumn(
                name: "Ano",
                table: "Vehiculos",
                newName: "tinyint");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Usuarios",
                newName: "varchar(20)");

            migrationBuilder.RenameColumn(
                name: "Monto",
                table: "Transacciones",
                newName: "Decimal(18,2)");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "TipoVehiculos",
                newName: "nvarchar(20)");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "TiposOperaciones",
                newName: "nvarchar(20)");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "TipoDocumentos",
                newName: "nvarcahr(20)");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "RevisionTecnicaConceptoTipos",
                newName: "nvachar(50)");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "RevisionTecnicaConceptos",
                newName: "nvachar(50)");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "Provincias",
                newName: "nvarchar(100)");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "Procedencias",
                newName: "nvarchar(20)");

            migrationBuilder.RenameColumn(
                name: "CUIL",
                table: "Personas",
                newName: "nvarchar(20)");

            migrationBuilder.RenameColumn(
                name: "Apellido",
                table: "Personas",
                newName: "nvarchar(100)");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "Partidos",
                newName: "nvarchar(100)");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "Paises",
                newName: "nvarchar(100)");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "EstadoCiviles",
                newName: "nvarchar(20)");

            migrationBuilder.RenameColumn(
                name: "CodigoPostal",
                table: "Direcciones",
                newName: "nvarchar(10)");

            migrationBuilder.RenameColumn(
                name: "Calle",
                table: "Direcciones",
                newName: "nvarchar(100)");

            migrationBuilder.RenameColumn(
                name: "NumeroCuenta",
                table: "Cuentas",
                newName: "nvarchar(50)");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "Cuentas",
                newName: "nvarchar(200)");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "ConceptosFinancieros",
                newName: "nvarchar(200)");

            migrationBuilder.AlterColumn<string>(
                name: "nvarchar(20)",
                table: "Vehiculos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<short>(
                name: "tinyint",
                table: "Vehiculos",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<string>(
                name: "varchar(20)",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Decimal(18,2)",
                table: "Transacciones",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "nvarchar(20)",
                table: "TipoVehiculos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nvarchar(20)",
                table: "TiposOperaciones",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nvarcahr(20)",
                table: "TipoDocumentos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nvachar(50)",
                table: "RevisionTecnicaConceptoTipos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nvachar(50)",
                table: "RevisionTecnicaConceptos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nvarchar(100)",
                table: "Provincias",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nvarchar(20)",
                table: "Procedencias",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nvarchar(20)",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nvarchar(100)",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nvarchar(100)",
                table: "Partidos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nvarchar(100)",
                table: "Paises",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Localidades",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nvarchar(20)",
                table: "EstadoCiviles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nvarchar(10)",
                table: "Direcciones",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nvarchar(100)",
                table: "Direcciones",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nvarchar(50)",
                table: "Cuentas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nvarchar(200)",
                table: "Cuentas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nvarchar(200)",
                table: "ConceptosFinancieros",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldNullable: true);
        }
    }
}
