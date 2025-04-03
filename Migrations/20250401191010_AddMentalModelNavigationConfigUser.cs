using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebLab.Migrations
{
    /// <inheritdoc />
    public partial class AddMentalModelNavigationConfigUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "MentalModelNavigationConfigs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MentalModelNavigationConfigs_Users_UserId",
                table: "MentalModelNavigationConfigs");

            migrationBuilder.DropIndex(
                name: "IX_MentalModelNavigationConfigs_UserId",
                table: "MentalModelNavigationConfigs");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "MentalModelNavigationConfigs");
        }
    }
}
