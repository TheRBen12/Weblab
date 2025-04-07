using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebLab.Migrations
{
    /// <inheritdoc />
    public partial class AddRecallRecogTimeToClickFirstCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TimeToClickFirstCategoryLink",
                table: "RecallRecognitionExperimentExecutions",
                type: "integer",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeToClickFirstCategoryLink",
                table: "RecallRecognitionExperimentExecutions");
        }
    }
}
