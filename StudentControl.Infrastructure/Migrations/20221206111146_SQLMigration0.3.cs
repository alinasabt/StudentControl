using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentControl.Infrastructure.Migrations
{
    public partial class SQLMigration03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Groups_GroupId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "GroipID",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "GroupId",
                table: "Students",
                newName: "GroupID");

            migrationBuilder.RenameIndex(
                name: "IX_Students_GroupId",
                table: "Students",
                newName: "IX_Students_GroupID");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Groups_GroupID",
                table: "Students",
                column: "GroupID",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Groups_GroupID",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "GroupID",
                table: "Students",
                newName: "GroupId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_GroupID",
                table: "Students",
                newName: "IX_Students_GroupId");

            migrationBuilder.AddColumn<Guid>(
                name: "GroipID",
                table: "Students",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Groups_GroupId",
                table: "Students",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
