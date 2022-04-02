using Microsoft.EntityFrameworkCore.Migrations;

namespace ZENBEAR.Data.Migrations
{
    public partial class rates2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Rates_TicketId",
                table: "Rates");

            migrationBuilder.AddColumn<int>(
                name: "RateId",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Rates_TicketId",
                table: "Rates",
                column: "TicketId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Rates_TicketId",
                table: "Rates");

            migrationBuilder.DropColumn(
                name: "RateId",
                table: "Tickets");

            migrationBuilder.CreateIndex(
                name: "IX_Rates_TicketId",
                table: "Rates",
                column: "TicketId");
        }
    }
}
