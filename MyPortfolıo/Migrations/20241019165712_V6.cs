using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPortfolıo.Migrations
{
    public partial class V6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GithubUrl",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LinkedinUrl",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MediumUrl",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GithubUrl",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "LinkedinUrl",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "MediumUrl",
                table: "Abouts");
        }
    }
}
