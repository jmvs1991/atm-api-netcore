using Microsoft.EntityFrameworkCore.Migrations;

namespace atm_api_net_core.Migrations
{
    public partial class agregandoColumnaBloqueado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Bloqueado",
                table: "Tarjeta",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bloqueado",
                table: "Tarjeta");
        }
    }
}
