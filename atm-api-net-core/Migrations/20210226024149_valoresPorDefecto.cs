using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace atm_api_net_core.Migrations
{
    public partial class valoresPorDefecto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tarjeta",
                keyColumn: "IdTarjeta",
                keyValue: -1);

            migrationBuilder.InsertData(
                table: "Tarjeta",
                columns: new[] { "IdTarjeta", "Fecha_Actualizacion", "Intentos", "Numero", "Pin" },
                values: new object[] { 1, new DateTime(2021, 2, 25, 23, 41, 49, 9, DateTimeKind.Local).AddTicks(5140), 0, "1111111111111111", "1234" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tarjeta",
                keyColumn: "IdTarjeta",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "Tarjeta",
                columns: new[] { "IdTarjeta", "Fecha_Actualizacion", "Intentos", "Numero", "Pin" },
                values: new object[] { -1, new DateTime(2021, 2, 25, 23, 36, 50, 231, DateTimeKind.Local).AddTicks(2308), 0, "1111111111111111", "1234" });
        }
    }
}
