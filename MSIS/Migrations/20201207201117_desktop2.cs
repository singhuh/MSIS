using Microsoft.EntityFrameworkCore.Migrations;

namespace MSIS.Migrations
{
    public partial class desktop2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LinkedIn",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LinkedIn",
                table: "Users");
        }
    }
}
