using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentControl.Infrastructure.Migrations
{
    public partial class Migration1212222nd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Groups_GroupID",
                table: "Students");

            migrationBuilder.AlterColumn<Guid>(
                name: "GroupID",
                table: "Students",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci",
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Groups_GroupID",
                table: "Students",
                column: "GroupID",
                principalTable: "Groups",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Groups_GroupID",
                table: "Students");

            migrationBuilder.AlterColumn<Guid>(
                name: "GroupID",
                table: "Students",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci",
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true)
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Groups_GroupID",
                table: "Students",
                column: "GroupID",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
