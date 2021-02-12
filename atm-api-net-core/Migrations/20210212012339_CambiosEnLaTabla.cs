using Microsoft.EntityFrameworkCore.Migrations;

namespace atm_api_net_core.Migrations
{
    public partial class CambiosEnLaTabla : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TARJETA",
                table: "TARJETA");

            migrationBuilder.RenameTable(
                name: "TARJETA",
                newName: "Tarjeta");

            migrationBuilder.RenameColumn(
                name: "PIN",
                table: "Tarjeta",
                newName: "Pin");

            migrationBuilder.RenameColumn(
                name: "NUMERO",
                table: "Tarjeta",
                newName: "Numero");

            migrationBuilder.RenameColumn(
                name: "ID_TARJETA",
                table: "Tarjeta",
                newName: "IdTarjeta");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tarjeta",
                table: "Tarjeta",
                column: "IdTarjeta");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tarjeta",
                table: "Tarjeta");

            migrationBuilder.RenameTable(
                name: "Tarjeta",
                newName: "TARJETA");

            migrationBuilder.RenameColumn(
                name: "Pin",
                table: "TARJETA",
                newName: "PIN");

            migrationBuilder.RenameColumn(
                name: "Numero",
                table: "TARJETA",
                newName: "NUMERO");

            migrationBuilder.RenameColumn(
                name: "IdTarjeta",
                table: "TARJETA",
                newName: "ID_TARJETA");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TARJETA",
                table: "TARJETA",
                column: "ID_TARJETA");
        }
    }
}
