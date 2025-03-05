using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class AddConstraitsInFluentBookAndFluentBookDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FluentBooks_BookDetails_BookDetailId",
                table: "FluentBooks");

            migrationBuilder.DropIndex(
                name: "IX_FluentBooks_BookDetailId",
                table: "FluentBooks");

            migrationBuilder.DropColumn(
                name: "BookDetailId",
                table: "FluentBooks");

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "FluentBookDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_FluentBookDetails_BookId",
                table: "FluentBookDetails",
                column: "BookId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_FluentBookDetails_FluentBooks_BookId",
                table: "FluentBookDetails",
                column: "BookId",
                principalTable: "FluentBooks",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FluentBookDetails_FluentBooks_BookId",
                table: "FluentBookDetails");

            migrationBuilder.DropIndex(
                name: "IX_FluentBookDetails_BookId",
                table: "FluentBookDetails");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "FluentBookDetails");

            migrationBuilder.AddColumn<int>(
                name: "BookDetailId",
                table: "FluentBooks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FluentBooks_BookDetailId",
                table: "FluentBooks",
                column: "BookDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_FluentBooks_BookDetails_BookDetailId",
                table: "FluentBooks",
                column: "BookDetailId",
                principalTable: "BookDetails",
                principalColumn: "BookDetailId");
        }
    }
}
