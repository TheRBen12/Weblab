using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebLab.Migrations
{
    /// <inheritdoc />
    public partial class AddUpdateTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserNavigationTimes_Experiments_FromExperimentId",
                table: "UserNavigationTimes");

            migrationBuilder.DropForeignKey(
                name: "FK_UserNavigationTimes_Experiments_ToExperimentId",
                table: "UserNavigationTimes");

            migrationBuilder.AddForeignKey(
                name: "FK_UserNavigationTimes_ExperimentTests_FromExperimentId",
                table: "UserNavigationTimes",
                column: "FromExperimentId",
                principalTable: "ExperimentTests",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserNavigationTimes_ExperimentTests_ToExperimentId",
                table: "UserNavigationTimes",
                column: "ToExperimentId",
                principalTable: "ExperimentTests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserNavigationTimes_ExperimentTests_FromExperimentId",
                table: "UserNavigationTimes");

            migrationBuilder.DropForeignKey(
                name: "FK_UserNavigationTimes_ExperimentTests_ToExperimentId",
                table: "UserNavigationTimes");

            migrationBuilder.AddForeignKey(
                name: "FK_UserNavigationTimes_Experiments_FromExperimentId",
                table: "UserNavigationTimes",
                column: "FromExperimentId",
                principalTable: "Experiments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserNavigationTimes_Experiments_ToExperimentId",
                table: "UserNavigationTimes",
                column: "ToExperimentId",
                principalTable: "Experiments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
