using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebLab.Migrations
{
    /// <inheritdoc />
    public partial class AddTimeToFirstClickOnCategoryLink : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TimeToClickFirstCategoryLink",
                table: "HicksLawExperimentExecutions",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeToClickFirstCategoryLink",
                table: "HicksLawExperimentExecutions");
        }
    }
}
