using Microsoft.EntityFrameworkCore.Migrations;

namespace CarAgency.Migrations
{
    public partial class mig15022021_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transacciones_Vehiculos_VehiculoId",
                table: "Transacciones");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transacciones_Vehiculos_VehiculoId",
                table: "Transacciones");

            migrationBuilder.AlterColumn<int>(
                name: "VehiculoId",
                table: "Transacciones",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Transacciones_Vehiculos_VehiculoId",
                table: "Transacciones",
                column: "VehiculoId",
                principalTable: "Vehiculos",
                principalColumn: "VehiculoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
