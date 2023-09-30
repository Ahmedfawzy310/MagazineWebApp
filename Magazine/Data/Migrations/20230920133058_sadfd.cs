using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Magazine.Data.Migrations
{
    /// <inheritdoc />
    public partial class sadfd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_TargetGenders_TargetGenderId",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_TargetGenderId",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "GenderId",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "TargetGenderId",
                table: "Articles");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GenderId",
                table: "Articles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TargetGenderId",
                table: "Articles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Articles_TargetGenderId",
                table: "Articles",
                column: "TargetGenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_TargetGenders_TargetGenderId",
                table: "Articles",
                column: "TargetGenderId",
                principalTable: "TargetGenders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
