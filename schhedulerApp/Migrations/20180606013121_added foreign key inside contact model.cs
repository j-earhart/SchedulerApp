using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace schhedulerApp.Migrations
{
    public partial class addedforeignkeyinsidecontactmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Comment",
                table: "Contacts",
                newName: "Comments");

            migrationBuilder.AddColumn<int>(
                name: "ServiceId",
                table: "Contacts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_ServiceId",
                table: "Contacts",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Services_ServiceId",
                table: "Contacts",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Services_ServiceId",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_ServiceId",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "Contacts");

            migrationBuilder.RenameColumn(
                name: "Comments",
                table: "Contacts",
                newName: "Comment");
        }
    }
}
