using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthIdentity.Data.Migrations
{
    public partial class addFavoritToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FavoritColor",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "fullName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FavoritColor",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "fullName",
                table: "AspNetUsers");
        }
    }
}
