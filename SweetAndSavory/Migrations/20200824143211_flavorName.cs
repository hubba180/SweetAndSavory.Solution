using Microsoft.EntityFrameworkCore.Migrations;

namespace SweetAndSavory.Migrations
{
    public partial class flavorName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Flavors",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Flavors");
        }
    }
}
