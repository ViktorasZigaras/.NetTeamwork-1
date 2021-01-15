using Microsoft.EntityFrameworkCore.Migrations;

namespace Homework.WebApp.Migrations
{
    public partial class InitialAccountsMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Balance",
                table: "Accounts",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<long>(
                name: "PersonalId",
                table: "Accounts",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "UserLastName",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "User_id",
                table: "Accounts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Balance",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "PersonalId",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "UserLastName",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "User_id",
                table: "Accounts");
        }
    }
}
