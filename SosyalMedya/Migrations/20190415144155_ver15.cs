using Microsoft.EntityFrameworkCore.Migrations;

namespace SosyalMedya.Migrations
{
    public partial class ver15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UrunId",
                table: "Siparis");

            migrationBuilder.AddColumn<float>(
                name: "Fiyat",
                table: "Siparis",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "Kullanici_adres",
                table: "Siparis",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UrunAdi",
                table: "Siparis",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fiyat",
                table: "Siparis");

            migrationBuilder.DropColumn(
                name: "Kullanici_adres",
                table: "Siparis");

            migrationBuilder.DropColumn(
                name: "UrunAdi",
                table: "Siparis");

            migrationBuilder.AddColumn<int>(
                name: "UrunId",
                table: "Siparis",
                nullable: false,
                defaultValue: 0);
        }
    }
}
