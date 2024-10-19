using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPortfolıo.Migrations
{
    public partial class V7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExperienceId",
                table: "Experiences",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Experiences",
                newName: "ExperienceId");
        }
    }
}
