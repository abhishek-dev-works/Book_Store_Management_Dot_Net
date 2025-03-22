using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreManagement_Db_Context.Migrations
{
    public partial class newTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entries_Books_BookId",
                table: "Entries");

            migrationBuilder.DropForeignKey(
                name: "FK_Entries_Users_UserId",
                table: "Entries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Entries",
                table: "Entries");

            migrationBuilder.RenameTable(
                name: "Entries",
                newName: "Records");

            migrationBuilder.RenameIndex(
                name: "IX_Entries_UserId",
                table: "Records",
                newName: "IX_Records_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Entries_BookId",
                table: "Records",
                newName: "IX_Records_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Records",
                table: "Records",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Records_Books_BookId",
                table: "Records",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Records_Users_UserId",
                table: "Records",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Records_Books_BookId",
                table: "Records");

            migrationBuilder.DropForeignKey(
                name: "FK_Records_Users_UserId",
                table: "Records");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Records",
                table: "Records");

            migrationBuilder.RenameTable(
                name: "Records",
                newName: "Entries");

            migrationBuilder.RenameIndex(
                name: "IX_Records_UserId",
                table: "Entries",
                newName: "IX_Entries_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Records_BookId",
                table: "Entries",
                newName: "IX_Entries_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Entries",
                table: "Entries",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Entries_Books_BookId",
                table: "Entries",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Entries_Users_UserId",
                table: "Entries",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
