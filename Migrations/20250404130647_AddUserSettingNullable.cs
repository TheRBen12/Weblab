using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebLab.Migrations
{
    /// <inheritdoc />
    public partial class AddUserSettingNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserSettingId",
                table: "UserNavigationTimes",
                type: "integer",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UserNavigationTimes_UserSettingId",
                table: "UserNavigationTimes",
                column: "UserSettingId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserNavigationTimes_UserSettings_UserSettingId",
                table: "UserNavigationTimes",
                column: "UserSettingId",
                principalTable: "UserSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserNavigationTimes_UserSettings_UserSettingId",
                table: "UserNavigationTimes");

            migrationBuilder.DropIndex(
                name: "IX_UserNavigationTimes_UserSettingId",
                table: "UserNavigationTimes");

            migrationBuilder.DropColumn(
                name: "UserSettingId",
                table: "UserNavigationTimes");
        }
    }
}
