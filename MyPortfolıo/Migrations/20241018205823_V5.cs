using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPortfolıo.Migrations
{
    public partial class V5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Url",
                table: "SocialMedias",
                newName: "MediumUrl");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "SocialMedias",
                newName: "LinkedinUrl");

            migrationBuilder.AddColumn<string>(
                name: "GithubUrl",
                table: "SocialMedias",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GithubUrl",
                table: "SocialMedias");

            migrationBuilder.RenameColumn(
                name: "MediumUrl",
                table: "SocialMedias",
                newName: "Url");

            migrationBuilder.RenameColumn(
                name: "LinkedinUrl",
                table: "SocialMedias",
                newName: "Title");
        }
    }
}
