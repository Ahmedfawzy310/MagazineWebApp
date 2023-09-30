using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Magazine.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedadmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into AspNetUserRoles (UserId,RoleId) select '4d7f0755-bcd3-49b6-be7c-876285346a2f', Id from AspNetRoles");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from AspNetUserRoles where UserId='4d7f0755-bcd3-49b6-be7c-876285346a2f'");
        }
    }
}
