using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebLab.Migrations
{
    /// <inheritdoc />
    public partial class AddMentalModelNavigationConfigUserId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MentalModelNavigationConfigs_Users_UserId",
                table: "MentalModelNavigationConfigs");

            migrationBuilder.DropIndex(
                name: "IX_MentalModelNavigationConfigs_UserId",
                table: "MentalModelNavigationConfigs");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_MentalModelNavigationConfigs_UserId",
                table: "MentalModelNavigationConfigs",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_MentalModelNavigationConfigs_Users_UserId",
                table: "MentalModelNavigationConfigs",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
