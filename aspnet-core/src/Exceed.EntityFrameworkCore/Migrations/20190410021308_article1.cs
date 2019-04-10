using Microsoft.EntityFrameworkCore.Migrations;

namespace Exceed.Migrations
{
    public partial class article1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Key",
                table: "ArticlePages",
                newName: "FindKey");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FindKey",
                table: "ArticlePages",
                newName: "Key");
        }
    }
}
