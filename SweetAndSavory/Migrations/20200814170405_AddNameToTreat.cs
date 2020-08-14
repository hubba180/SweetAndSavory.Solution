using Microsoft.EntityFrameworkCore.Migrations;

namespace SweetAndSavory.Migrations
{
    public partial class AddNameToTreat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Treats",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Treats");
        }
    }
}
