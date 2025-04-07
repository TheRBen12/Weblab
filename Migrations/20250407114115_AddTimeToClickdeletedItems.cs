using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebLab.Migrations
{
    /// <inheritdoc />
    public partial class AddTimeToClickdeletedItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TimeToClickOnDeletedItems",
                table: "ErrorCorrectionExperimentExecutions",
                type: "integer",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeToClickOnDeletedItems",
                table: "ErrorCorrectionExperimentExecutions");
        }
    }
}
