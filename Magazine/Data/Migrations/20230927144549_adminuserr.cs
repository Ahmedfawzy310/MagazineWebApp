using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Magazine.Data.Migrations
{
    /// <inheritdoc />
    public partial class adminuserr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Cover], [FirstName], [LastName]) VALUES (N'4d7f0755-bcd3-49b6-be7c-876285346a2f', N'admin@gmail.com', N'ADMIN@GMAIL.COM', N'admin@gmail.com', N'ADMIN@GMAIL.COM', 0, N'AQAAAAIAAYagAAAAEGROIL/wMpkXnQZDBkirdRIgo5Bl8AzprOCsFoOa+DlPZMcoNNi9f7l+E4q6NEfjeg==', N'O4TXESF5LNQQ3G3ZIMIBWO4SVL2TDNGA', N'41b0cc9e-a1e6-4696-9f05-9d03ca37a400', NULL, 0, 0, NULL, 1, 0, null, N'admin', N'admin')\r\n");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM AspNetUsers WHERE Id='4d7f0755-bcd3-49b6-be7c-876285346a2f'");
        }
    }
}
