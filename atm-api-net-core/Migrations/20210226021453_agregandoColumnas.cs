using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace atm_api_net_core.Migrations
{
    public partial class agregandoColumnas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Numero",
                table: "Tarjeta",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                defaultValue: "0",
                oldClrType: typeof(string),
                oldType: "nvarchar(16)",
                oldMaxLength: 16);

            migrationBuilder.AddColumn<DateTime>(
                name: "Fecha_Actualizacion",
                table: "Tarjeta",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()");

            migrationBuilder.AddColumn<DateTime>(
                name: "Fecha_Creacion",
                table: "Tarjeta",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()");

            migrationBuilder.AddColumn<int>(
                name: "Intentos",
                table: "Tarjeta",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fecha_Actualizacion",
                table: "Tarjeta");

            migrationBuilder.DropColumn(
                name: "Fecha_Creacion",
                table: "Tarjeta");

            migrationBuilder.DropColumn(
                name: "Intentos",
                table: "Tarjeta");

            migrationBuilder.AlterColumn<string>(
                name: "Numero",
                table: "Tarjeta",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(16)",
                oldMaxLength: 16,
                oldDefaultValue: "0");
        }
    }
}
