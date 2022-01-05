using Microsoft.EntityFrameworkCore.Migrations;

namespace NorthParallelProjectManagmentSoftware.Data.Migrations
{
    public partial class maincompticket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TicketCompanyCompanyId",
                table: "Tickets",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_TicketCompanyCompanyId",
                table: "Tickets",
                column: "TicketCompanyCompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Company_TicketCompanyCompanyId",
                table: "Tickets",
                column: "TicketCompanyCompanyId",
                principalTable: "Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Company_TicketCompanyCompanyId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_TicketCompanyCompanyId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "TicketCompanyCompanyId",
                table: "Tickets");
        }
    }
}
