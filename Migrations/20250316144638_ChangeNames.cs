using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebLab.Migrations
{
    /// <inheritdoc />
    public partial class ChangeNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NumberOnSettings",
                table: "UserBehaviours",
                newName: "TimeReadingWelcomeModal");

            migrationBuilder.AddColumn<int>(
                name: "NumberClickedOnSettings",
                table: "UserBehaviours",
                type: "integer",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberClickedOnSettings",
                table: "UserBehaviours");

            migrationBuilder.RenameColumn(
                name: "TimeReadingWelcomeModal",
                table: "UserBehaviours",
                newName: "NumberOnSettings");
        }
    }
}
