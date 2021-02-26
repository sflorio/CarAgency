using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarAgency.Migrations
{
    public partial class NewSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ConceptosFinancieros",
                keyColumn: "ConceptoFinancieroId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ConceptosFinancieros",
                keyColumn: "ConceptoFinancieroId",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "EstadosCiviles",
                keyColumn: "EstadoCivilId",
                keyValue: 1,
                column: "CreateDateTime",
                value: new DateTime(2021, 2, 25, 23, 33, 57, 504, DateTimeKind.Local).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "EstadosCiviles",
                keyColumn: "EstadoCivilId",
                keyValue: 2,
                column: "CreateDateTime",
                value: new DateTime(2021, 2, 25, 23, 33, 57, 505, DateTimeKind.Local).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "EstadosCiviles",
                keyColumn: "EstadoCivilId",
                keyValue: 3,
                column: "CreateDateTime",
                value: new DateTime(2021, 2, 25, 23, 33, 57, 505, DateTimeKind.Local).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "EstadosCiviles",
                keyColumn: "EstadoCivilId",
                keyValue: 4,
                column: "CreateDateTime",
                value: new DateTime(2021, 2, 25, 23, 33, 57, 505, DateTimeKind.Local).AddTicks(8394));

            migrationBuilder.InsertData(
                table: "TiposOperaciones",
                columns: new[] { "TipoOperacionId", "Active", "CreateDateTime", "CreateUser", "DeleteDateTime", "DeleteUser", "Descripcion", "UpdateDateTime", "UpdateUser" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2021, 2, 25, 23, 33, 57, 506, DateTimeKind.Local).AddTicks(295), "migration", null, null, "Debito", null, null },
                    { 2, true, new DateTime(2021, 2, 25, 23, 33, 57, 506, DateTimeKind.Local).AddTicks(341), "migration", null, null, "Credito", null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TiposOperaciones",
                keyColumn: "TipoOperacionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TiposOperaciones",
                keyColumn: "TipoOperacionId",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "ConceptosFinancieros",
                columns: new[] { "ConceptoFinancieroId", "Active", "CreateDateTime", "CreateUser", "DeleteDateTime", "DeleteUser", "Descripcion", "UpdateDateTime", "UpdateUser" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2021, 2, 25, 23, 28, 44, 140, DateTimeKind.Local).AddTicks(1761), "migration", null, null, "Debito", null, null },
                    { 2, true, new DateTime(2021, 2, 25, 23, 28, 44, 140, DateTimeKind.Local).AddTicks(1806), "migration", null, null, "Credito", null, null }
                });

            migrationBuilder.UpdateData(
                table: "EstadosCiviles",
                keyColumn: "EstadoCivilId",
                keyValue: 1,
                column: "CreateDateTime",
                value: new DateTime(2021, 2, 25, 23, 28, 44, 138, DateTimeKind.Local).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "EstadosCiviles",
                keyColumn: "EstadoCivilId",
                keyValue: 2,
                column: "CreateDateTime",
                value: new DateTime(2021, 2, 25, 23, 28, 44, 139, DateTimeKind.Local).AddTicks(9843));

            migrationBuilder.UpdateData(
                table: "EstadosCiviles",
                keyColumn: "EstadoCivilId",
                keyValue: 3,
                column: "CreateDateTime",
                value: new DateTime(2021, 2, 25, 23, 28, 44, 139, DateTimeKind.Local).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "EstadosCiviles",
                keyColumn: "EstadoCivilId",
                keyValue: 4,
                column: "CreateDateTime",
                value: new DateTime(2021, 2, 25, 23, 28, 44, 139, DateTimeKind.Local).AddTicks(9883));
        }
    }
}
