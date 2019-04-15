using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SosyalMedya.Migrations
{
    public partial class ver16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RestorantAd",
                table: "Siparis",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "tarih",
                table: "Siparis",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RestorantAd",
                table: "Siparis");

            migrationBuilder.DropColumn(
                name: "tarih",
                table: "Siparis");
        }
    }
}
