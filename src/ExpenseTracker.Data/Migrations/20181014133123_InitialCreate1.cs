using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExpenseTracker.Data.Migrations
{
    public partial class InitialCreate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_Tags_TagId",
                table: "Expenses");

            migrationBuilder.DropForeignKey(
                name: "FK_Tags_Expenses_ExpenseId",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Tags_ExpenseId",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Expenses_TagId",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "ExpenseId",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "TagId",
                table: "Expenses");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ExpenseId",
                table: "Tags",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TagId",
                table: "Expenses",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tags_ExpenseId",
                table: "Tags",
                column: "ExpenseId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_TagId",
                table: "Expenses",
                column: "TagId");

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_Tags_TagId",
                table: "Expenses",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_Expenses_ExpenseId",
                table: "Tags",
                column: "ExpenseId",
                principalTable: "Expenses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
