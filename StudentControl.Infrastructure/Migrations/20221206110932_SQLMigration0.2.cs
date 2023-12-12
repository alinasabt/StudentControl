using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentControl.Infrastructure.Migrations
{
    public partial class SQLMigration02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Logins_LoginId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_LoginId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "LoginId",
                table: "Students");

            migrationBuilder.AddColumn<Guid>(
                name: "GroipID",
                table: "Students",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "StudentID",
                table: "Logins",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.CreateIndex(
                name: "IX_Logins_StudentID",
                table: "Logins",
                column: "StudentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Logins_Students_StudentID",
                table: "Logins",
                column: "StudentID",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Logins_Students_StudentID",
                table: "Logins");

            migrationBuilder.DropIndex(
                name: "IX_Logins_StudentID",
                table: "Logins");

            migrationBuilder.DropColumn(
                name: "GroipID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StudentID",
                table: "Logins");

            migrationBuilder.AddColumn<Guid>(
                name: "LoginId",
                table: "Students",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.CreateIndex(
                name: "IX_Students_LoginId",
                table: "Students",
                column: "LoginId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Logins_LoginId",
                table: "Students",
                column: "LoginId",
                principalTable: "Logins",
                principalColumn: "Id");
        }
    }
}
