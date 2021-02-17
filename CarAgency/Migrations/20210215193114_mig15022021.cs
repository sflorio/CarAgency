using Microsoft.EntityFrameworkCore.Migrations;

namespace CarAgency.Migrations
{
    public partial class mig15022021 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transacciones_Vehiculos_VehiculoId",
                table: "Transacciones");

            migrationBuilder.AddColumn<int>(
                name: "RevisionTecnicaId",
                table: "Vehiculos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TitularPersonaId",
                table: "Vehiculos",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VehiculoId",
                table: "Transacciones",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_RevisionTecnicaId",
                table: "Vehiculos",
                column: "RevisionTecnicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_TitularPersonaId",
                table: "Vehiculos",
                column: "TitularPersonaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transacciones_Vehiculos_VehiculoId",
                table: "Transacciones",
                column: "VehiculoId",
                principalTable: "Vehiculos",
                principalColumn: "VehiculoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Personas_TitularPersonaId",
                table: "Vehiculos",
                column: "TitularPersonaId",
                principalTable: "Personas",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_RevisionesTecnicas_RevisionTecnicaId",
                table: "Vehiculos",
                column: "RevisionTecnicaId",
                principalTable: "RevisionesTecnicas",
                principalColumn: "RevisionTecnicaId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transacciones_Vehiculos_VehiculoId",
                table: "Transacciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Personas_TitularPersonaId",
                table: "Vehiculos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_RevisionesTecnicas_RevisionTecnicaId",
                table: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_RevisionTecnicaId",
                table: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_TitularPersonaId",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "RevisionTecnicaId",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "TitularPersonaId",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Personas");

            migrationBuilder.AlterColumn<int>(
                name: "VehiculoId",
                table: "Transacciones",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Transacciones_Vehiculos_VehiculoId",
                table: "Transacciones",
                column: "VehiculoId",
                principalTable: "Vehiculos",
                principalColumn: "VehiculoId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
