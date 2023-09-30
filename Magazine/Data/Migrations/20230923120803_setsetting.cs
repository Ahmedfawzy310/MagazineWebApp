using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Magazine.Data.Migrations
{
    /// <inheritdoc />
    public partial class setsetting : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "FacebookLink", "GithupLink", "InstagramLink", "LinkedinLink", "TwiterLink" },
                values: new object[] { 1, "https://www.facebook.com/ahmed.ragp.129", "https://github.com/Ahmedfawzy310", "https://github.com/Ahmedfawzy310", "https://github.com/Ahmedfawzy310", "https://github.com/Ahmedfawzy310" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
