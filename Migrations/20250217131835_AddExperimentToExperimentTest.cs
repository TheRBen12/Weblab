using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebLab.Migrations
{
    /// <inheritdoc />
    public partial class AddExperimentToExperimentTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExperimentId",
                table: "ExperimentTests",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ExperimentTests_ExperimentId",
                table: "ExperimentTests",
                column: "ExperimentId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExperimentTests_Experiments_ExperimentId",
                table: "ExperimentTests",
                column: "ExperimentId",
                principalTable: "Experiments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExperimentTests_Experiments_ExperimentId",
                table: "ExperimentTests");

            migrationBuilder.DropIndex(
                name: "IX_ExperimentTests_ExperimentId",
                table: "ExperimentTests");

            migrationBuilder.DropColumn(
                name: "ExperimentId",
                table: "ExperimentTests");
        }
    }
}
