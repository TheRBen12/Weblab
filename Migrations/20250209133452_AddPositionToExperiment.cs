using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebLab.Migrations
{
    /// <inheritdoc />
    public partial class AddPositionToExperiment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "state",
                table: "Experiments",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Experiments",
                newName: "Name");

            migrationBuilder.AddColumn<int>(
                name: "Position",
                table: "Experiments",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Position",
                table: "Experiments");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Experiments",
                newName: "state");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Experiments",
                newName: "name");
        }
    }
}
