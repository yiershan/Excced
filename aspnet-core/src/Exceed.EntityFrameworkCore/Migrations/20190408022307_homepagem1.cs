using Microsoft.EntityFrameworkCore.Migrations;

namespace Exceed.Migrations
{
    public partial class homepagem1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PetMoreNav",
                table: "HomePages",
                newName: "PetMoreNavs");

            migrationBuilder.RenameColumn(
                name: "PetCircleNav",
                table: "HomePages",
                newName: "PetCircleNavs");

            migrationBuilder.RenameColumn(
                name: "ImgCircleNav",
                table: "HomePages",
                newName: "ImgCircleNavs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PetMoreNavs",
                table: "HomePages",
                newName: "PetMoreNav");

            migrationBuilder.RenameColumn(
                name: "PetCircleNavs",
                table: "HomePages",
                newName: "PetCircleNav");

            migrationBuilder.RenameColumn(
                name: "ImgCircleNavs",
                table: "HomePages",
                newName: "ImgCircleNav");
        }
    }
}
