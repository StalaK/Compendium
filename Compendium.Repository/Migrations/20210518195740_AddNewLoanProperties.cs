using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Compendium.Repository.Migrations
{
    public partial class AddNewLoanProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LoanDate",
                table: "LoanedGames",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ReturnDate",
                table: "LoanedGames",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LoanDate",
                table: "LoanedBooks",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ReturnDate",
                table: "LoanedBooks",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LoanDate",
                table: "LoanedBoardGames",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ReturnDate",
                table: "LoanedBoardGames",
                type: "timestamp without time zone",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LoanDate",
                table: "LoanedGames");

            migrationBuilder.DropColumn(
                name: "ReturnDate",
                table: "LoanedGames");

            migrationBuilder.DropColumn(
                name: "LoanDate",
                table: "LoanedBooks");

            migrationBuilder.DropColumn(
                name: "ReturnDate",
                table: "LoanedBooks");

            migrationBuilder.DropColumn(
                name: "LoanDate",
                table: "LoanedBoardGames");

            migrationBuilder.DropColumn(
                name: "ReturnDate",
                table: "LoanedBoardGames");
        }
    }
}
