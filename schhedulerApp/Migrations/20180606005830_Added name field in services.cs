using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace schhedulerApp.Migrations
{
    public partial class Addednamefieldinservices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Services",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Services");
        }
    }
}
