using Microsoft.EntityFrameworkCore.Migrations;

namespace Compendium.Repository.Migrations
{
    public partial class AddForeignKeyts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoanedBoardGames_People_PeopleId",
                table: "LoanedBoardGames");

            migrationBuilder.DropForeignKey(
                name: "FK_LoanedBooks_People_PeopleId",
                table: "LoanedBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_LoanedGames_People_PeopleId",
                table: "LoanedGames");

            migrationBuilder.RenameColumn(
                name: "PeopleId",
                table: "LoanedGames",
                newName: "LenderId");

            migrationBuilder.RenameIndex(
                name: "IX_LoanedGames_PeopleId",
                table: "LoanedGames",
                newName: "IX_LoanedGames_LenderId");

            migrationBuilder.RenameColumn(
                name: "PeopleId",
                table: "LoanedBooks",
                newName: "LenderId");

            migrationBuilder.RenameIndex(
                name: "IX_LoanedBooks_PeopleId",
                table: "LoanedBooks",
                newName: "IX_LoanedBooks_LenderId");

            migrationBuilder.RenameColumn(
                name: "PeopleId",
                table: "LoanedBoardGames",
                newName: "LenderId");

            migrationBuilder.RenameIndex(
                name: "IX_LoanedBoardGames_PeopleId",
                table: "LoanedBoardGames",
                newName: "IX_LoanedBoardGames_LenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_LoanedBoardGames_People_LenderId",
                table: "LoanedBoardGames",
                column: "LenderId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LoanedBooks_People_LenderId",
                table: "LoanedBooks",
                column: "LenderId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LoanedGames_People_LenderId",
                table: "LoanedGames",
                column: "LenderId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoanedBoardGames_People_LenderId",
                table: "LoanedBoardGames");

            migrationBuilder.DropForeignKey(
                name: "FK_LoanedBooks_People_LenderId",
                table: "LoanedBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_LoanedGames_People_LenderId",
                table: "LoanedGames");

            migrationBuilder.RenameColumn(
                name: "LenderId",
                table: "LoanedGames",
                newName: "PeopleId");

            migrationBuilder.RenameIndex(
                name: "IX_LoanedGames_LenderId",
                table: "LoanedGames",
                newName: "IX_LoanedGames_PeopleId");

            migrationBuilder.RenameColumn(
                name: "LenderId",
                table: "LoanedBooks",
                newName: "PeopleId");

            migrationBuilder.RenameIndex(
                name: "IX_LoanedBooks_LenderId",
                table: "LoanedBooks",
                newName: "IX_LoanedBooks_PeopleId");

            migrationBuilder.RenameColumn(
                name: "LenderId",
                table: "LoanedBoardGames",
                newName: "PeopleId");

            migrationBuilder.RenameIndex(
                name: "IX_LoanedBoardGames_LenderId",
                table: "LoanedBoardGames",
                newName: "IX_LoanedBoardGames_PeopleId");

            migrationBuilder.AddForeignKey(
                name: "FK_LoanedBoardGames_People_PeopleId",
                table: "LoanedBoardGames",
                column: "PeopleId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LoanedBooks_People_PeopleId",
                table: "LoanedBooks",
                column: "PeopleId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LoanedGames_People_PeopleId",
                table: "LoanedGames",
                column: "PeopleId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
