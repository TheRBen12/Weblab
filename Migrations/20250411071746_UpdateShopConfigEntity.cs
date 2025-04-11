using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebLab.Migrations
{
    /// <inheritdoc />
    public partial class UpdateShopConfigEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "MenuTitle",
                table: "MentalModelNavigationConfigs",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "MenuToggleIcon",
                table: "MentalModelNavigationConfigs",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MenuTitle",
                table: "MentalModelNavigationConfigs");

            migrationBuilder.DropColumn(
                name: "MenuToggleIcon",
                table: "MentalModelNavigationConfigs");
        }
    }
}
