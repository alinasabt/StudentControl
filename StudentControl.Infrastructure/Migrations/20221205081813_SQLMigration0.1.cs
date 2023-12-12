using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentControl.Infrastructure.Migrations
{
    public partial class SQLMigration01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderStudent_Orders_ordersId",
                table: "OrderStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderStudent_Students_studentsid",
                table: "OrderStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Groups_groupId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Logins_loginId",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "surname",
                table: "Students",
                newName: "Surname");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "Students",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "snils",
                table: "Students",
                newName: "Snils");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Students",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "middle_name",
                table: "Students",
                newName: "Middle_name");

            migrationBuilder.RenameColumn(
                name: "loginId",
                table: "Students",
                newName: "LoginId");

            migrationBuilder.RenameColumn(
                name: "groupId",
                table: "Students",
                newName: "GroupId");

            migrationBuilder.RenameColumn(
                name: "graduate",
                table: "Students",
                newName: "Graduate");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Students",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Students_loginId",
                table: "Students",
                newName: "IX_Students_LoginId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_groupId",
                table: "Students",
                newName: "IX_Students_GroupId");

            migrationBuilder.RenameColumn(
                name: "studentsid",
                table: "OrderStudent",
                newName: "StudentsId");

            migrationBuilder.RenameColumn(
                name: "ordersId",
                table: "OrderStudent",
                newName: "OrdersId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderStudent_studentsid",
                table: "OrderStudent",
                newName: "IX_OrderStudent_StudentsId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Orders",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "comment",
                table: "Orders",
                newName: "Comment");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "Logins",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Logins",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "formofstudy",
                table: "Groups",
                newName: "Formofstudy");

            migrationBuilder.AlterColumn<Guid>(
                name: "OrdersId",
                table: "OrderStudent",
                type: "char(36)",
                nullable: false,
                collation: "ascii_general_ci",
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Orders",
                type: "char(36)",
                nullable: false,
                collation: "ascii_general_ci",
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Number",
                table: "Orders",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderStudent_Orders_OrdersId",
                table: "OrderStudent",
                column: "OrdersId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderStudent_Students_StudentsId",
                table: "OrderStudent",
                column: "StudentsId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Groups_GroupId",
                table: "Students",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Logins_LoginId",
                table: "Students",
                column: "LoginId",
                principalTable: "Logins",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderStudent_Orders_OrdersId",
                table: "OrderStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderStudent_Students_StudentsId",
                table: "OrderStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Groups_GroupId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Logins_LoginId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "Students",
                newName: "surname");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Students",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "Snils",
                table: "Students",
                newName: "snils");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Students",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Middle_name",
                table: "Students",
                newName: "middle_name");

            migrationBuilder.RenameColumn(
                name: "LoginId",
                table: "Students",
                newName: "loginId");

            migrationBuilder.RenameColumn(
                name: "GroupId",
                table: "Students",
                newName: "groupId");

            migrationBuilder.RenameColumn(
                name: "Graduate",
                table: "Students",
                newName: "graduate");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Students",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Students_LoginId",
                table: "Students",
                newName: "IX_Students_loginId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_GroupId",
                table: "Students",
                newName: "IX_Students_groupId");

            migrationBuilder.RenameColumn(
                name: "StudentsId",
                table: "OrderStudent",
                newName: "studentsid");

            migrationBuilder.RenameColumn(
                name: "OrdersId",
                table: "OrderStudent",
                newName: "ordersId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderStudent_StudentsId",
                table: "OrderStudent",
                newName: "IX_OrderStudent_studentsid");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Orders",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Comment",
                table: "Orders",
                newName: "comment");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Logins",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Logins",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Formofstudy",
                table: "Groups",
                newName: "formofstudy");

            migrationBuilder.AlterColumn<string>(
                name: "ordersId",
                table: "OrderStudent",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Orders",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderStudent_Orders_ordersId",
                table: "OrderStudent",
                column: "ordersId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderStudent_Students_studentsid",
                table: "OrderStudent",
                column: "studentsid",
                principalTable: "Students",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Groups_groupId",
                table: "Students",
                column: "groupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Logins_loginId",
                table: "Students",
                column: "loginId",
                principalTable: "Logins",
                principalColumn: "Id");
        }
    }
}
