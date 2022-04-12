using Microsoft.EntityFrameworkCore.Migrations;

namespace ZENBEAR.Data.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Preority",
                table: "Tickets",
                newName: "Priority");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Priority",
                table: "Tickets",
                newName: "Preority");
        }
    }
}
