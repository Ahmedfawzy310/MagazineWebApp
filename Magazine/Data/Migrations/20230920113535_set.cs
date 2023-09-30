using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Magazine.Data.Migrations
{
    /// <inheritdoc />
    public partial class set : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TargetAudiences",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "athletes" },
                    { 2, "politicians" },
                    { 3, "businessmen" },
                    { 4, "patients" },
                    { 5, "students" },
                    { 6, "farmers" },
                    { 7, "the poor" },
                    { 8, "elderly" },
                    { 9, "youth" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TargetAudiences",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TargetAudiences",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TargetAudiences",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TargetAudiences",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TargetAudiences",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TargetAudiences",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TargetAudiences",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TargetAudiences",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TargetAudiences",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
