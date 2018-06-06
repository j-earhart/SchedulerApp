using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace schhedulerApp.Migrations
{
    public partial class addeddescriptionfield : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Services",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Services");
        }
    }
}
