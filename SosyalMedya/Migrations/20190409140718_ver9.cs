using Microsoft.EntityFrameworkCore.Migrations;

namespace SosyalMedya.Migrations
{
    public partial class ver9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ad",
                table: "Restorants",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ad",
                table: "Restorants");
        }
    }
}
