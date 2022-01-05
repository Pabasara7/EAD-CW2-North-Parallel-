﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NorthParallelProjectManagmentSoftware.Data.Migrations
{
    public partial class datedatatypeincompany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CompanyJoinedDate",
                table: "Company",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CompanyJoinedDate",
                table: "Company",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
