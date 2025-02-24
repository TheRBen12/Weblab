using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebLab.Migrations
{
    /// <inheritdoc />
    public partial class ChangeName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StorageCapacity",
                table: "Notebooks",
                newName: "Festplatte");

            migrationBuilder.RenameColumn(
                name: "Ram",
                table: "Notebooks",
                newName: "Arbeitsspeicher");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Festplatte",
                table: "Notebooks",
                newName: "StorageCapacity");

            migrationBuilder.RenameColumn(
                name: "Arbeitsspeicher",
                table: "Notebooks",
                newName: "Ram");
        }
    }
}
