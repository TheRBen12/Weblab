using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebLab.Migrations
{
    /// <inheritdoc />
    public partial class AddExperimentTestExecutionNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FinishedExecutionAt",
                table: "ExperimentTestExecutions",
                type: "timestamp with time zone",
                nullable: true);

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FinishedExecutionAt",
                table: "ExperimentTestExecutions",
                type: "timestamp with time zone",
                nullable: true);
        }
    }
}
