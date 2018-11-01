using Microsoft.EntityFrameworkCore.Migrations;

namespace ExpenseTracker.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Expenses",
                newName: "Title");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Expenses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Expenses");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Expenses",
                newName: "Name");
        }
    }
}
