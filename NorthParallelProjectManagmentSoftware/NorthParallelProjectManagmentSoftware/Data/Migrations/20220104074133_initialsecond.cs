using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NorthParallelProjectManagmentSoftware.Data.Migrations
{
    public partial class initialsecond : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Projects_TicketProjectProjectId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Projects_UserAssignedProjectsProjectId",
                table: "User");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectCompanyCompanyId = table.Column<int>(type: "int", nullable: false),
                    ProjectDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProjectEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MainCompany = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.ProjectId);
                    table.ForeignKey(
                        name: "FK_Project_Company_ProjectCompanyCompanyId",
                        column: x => x.ProjectCompanyCompanyId,
                        principalTable: "Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Project_ProjectCompanyCompanyId",
                table: "Project",
                column: "ProjectCompanyCompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Project_TicketProjectProjectId",
                table: "Tickets",
                column: "TicketProjectProjectId",
                principalTable: "Project",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Project_UserAssignedProjectsProjectId",
                table: "User",
                column: "UserAssignedProjectsProjectId",
                principalTable: "Project",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Project_TicketProjectProjectId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Project_UserAssignedProjectsProjectId",
                table: "User");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainCompany = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectCompanyCompanyId = table.Column<int>(type: "int", nullable: false),
                    ProjectDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectEndDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectStartDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectId);
                    table.ForeignKey(
                        name: "FK_Projects_Company_ProjectCompanyCompanyId",
                        column: x => x.ProjectCompanyCompanyId,
                        principalTable: "Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ProjectCompanyCompanyId",
                table: "Projects",
                column: "ProjectCompanyCompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Projects_TicketProjectProjectId",
                table: "Tickets",
                column: "TicketProjectProjectId",
                principalTable: "Projects",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Projects_UserAssignedProjectsProjectId",
                table: "User",
                column: "UserAssignedProjectsProjectId",
                principalTable: "Projects",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
