using Microsoft.EntityFrameworkCore.Migrations;

namespace Dept2.Data.Migrations
{
    public partial class Persons : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Resume",
                table: "Persons");

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Link",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name_en",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name_ru",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name_uk",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Rank",
                table: "Persons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Resume_en",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Resume_ru",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Resume_uk",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Link",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Name_en",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Name_ru",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Name_uk",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Rank",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Resume_en",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Resume_ru",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Resume_uk",
                table: "Persons");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Persons",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Resume",
                table: "Persons",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true);
        }
    }
}
