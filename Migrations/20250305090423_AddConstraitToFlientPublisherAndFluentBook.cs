using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class AddConstraitToFlientPublisherAndFluentBook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PublisherId",
                table: "FluentBooks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_FluentBooks_PublisherId",
                table: "FluentBooks",
                column: "PublisherId");

            migrationBuilder.AddForeignKey(
                name: "FK_FluentBooks_FluentPublishers_PublisherId",
                table: "FluentBooks",
                column: "PublisherId",
                principalTable: "FluentPublishers",
                principalColumn: "PublisherId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FluentBooks_FluentPublishers_PublisherId",
                table: "FluentBooks");

            migrationBuilder.DropIndex(
                name: "IX_FluentBooks_PublisherId",
                table: "FluentBooks");

            migrationBuilder.DropColumn(
                name: "PublisherId",
                table: "FluentBooks");
        }
    }
}
