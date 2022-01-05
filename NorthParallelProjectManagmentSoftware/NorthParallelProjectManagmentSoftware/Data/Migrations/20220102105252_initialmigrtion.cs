using Microsoft.EntityFrameworkCore.Migrations;

namespace NorthParallelProjectManagmentSoftware.Data.Migrations
{
    public partial class initialmigrtion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyJoinedDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainCompany = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectCompanyCompanyId = table.Column<int>(type: "int", nullable: false),
                    ProjectDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectStartDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectEndDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainCompany = table.Column<string>(type: "nvarchar(max)", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserAuthorityLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserAssignedCompanyCompanyId = table.Column<int>(type: "int", nullable: true),
                    UserAssignedProjectsProjectId = table.Column<int>(type: "int", nullable: true),
                    MainCompany = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_User_Company_UserAssignedCompanyCompanyId",
                        column: x => x.UserAssignedCompanyCompanyId,
                        principalTable: "Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_Projects_UserAssignedProjectsProjectId",
                        column: x => x.UserAssignedProjectsProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    TicketId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TicketName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TicketProjectProjectId = table.Column<int>(type: "int", nullable: false),
                    TicketAssignedUserUserId = table.Column<int>(type: "int", nullable: false),
                    TicketDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TicketProgress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TicketCurrentStateUpdate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TicketStartDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainCompany = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.TicketId);
                    table.ForeignKey(
                        name: "FK_Tickets_Projects_TicketProjectProjectId",
                        column: x => x.TicketProjectProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_User_TicketAssignedUserUserId",
                        column: x => x.TicketAssignedUserUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ProjectCompanyCompanyId",
                table: "Projects",
                column: "ProjectCompanyCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_TicketAssignedUserUserId",
                table: "Tickets",
                column: "TicketAssignedUserUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_TicketProjectProjectId",
                table: "Tickets",
                column: "TicketProjectProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_User_UserAssignedCompanyCompanyId",
                table: "User",
                column: "UserAssignedCompanyCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_User_UserAssignedProjectsProjectId",
                table: "User",
                column: "UserAssignedProjectsProjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Company");
        }
    }
}
