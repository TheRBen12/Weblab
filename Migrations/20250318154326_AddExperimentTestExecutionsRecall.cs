using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace WebLab.Migrations
{
    /// <inheritdoc />
    public partial class AddExperimentTestExecutionsRecall : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExperimentTestExecutions_ExperimentTestExecutions_Experimen~",
                table: "ExperimentTestExecutions");

            migrationBuilder.DropIndex(
                name: "IX_ExperimentTestExecutions_ExperimentTestExecutionId",
                table: "ExperimentTestExecutions");

            migrationBuilder.DropColumn(
                name: "CategoryLinkClickDates",
                table: "ExperimentTestExecutions");

            migrationBuilder.DropColumn(
                name: "ClickedOnSearchBar",
                table: "ExperimentTestExecutions");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "ExperimentTestExecutions");

            migrationBuilder.DropColumn(
                name: "ExperimentTestExecutionId",
                table: "ExperimentTestExecutions");

            migrationBuilder.DropColumn(
                name: "FailedClicks",
                table: "ExperimentTestExecutions");

            migrationBuilder.CreateTable(
                name: "RecallRecognitionExperimentExecutions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ExperimentTestExecutionId = table.Column<int>(type: "integer", nullable: false),
                    CategoryLinkClickDates = table.Column<string>(type: "text", nullable: true),
                    FailedClicks = table.Column<int>(type: "integer", nullable: false),
                    ClickedOnSearchBar = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecallRecognitionExperimentExecutions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecallRecognitionExperimentExecutions_ExperimentTestExecuti~",
                        column: x => x.ExperimentTestExecutionId,
                        principalTable: "ExperimentTestExecutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RecallRecognitionExperimentExecutions_ExperimentTestExecuti~",
                table: "RecallRecognitionExperimentExecutions",
                column: "ExperimentTestExecutionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecallRecognitionExperimentExecutions");

            migrationBuilder.AddColumn<string>(
                name: "CategoryLinkClickDates",
                table: "ExperimentTestExecutions",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ClickedOnSearchBar",
                table: "ExperimentTestExecutions",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "ExperimentTestExecutions",
                type: "character varying(55)",
                maxLength: 55,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ExperimentTestExecutionId",
                table: "ExperimentTestExecutions",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FailedClicks",
                table: "ExperimentTestExecutions",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ExperimentTestExecutions_ExperimentTestExecutionId",
                table: "ExperimentTestExecutions",
                column: "ExperimentTestExecutionId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExperimentTestExecutions_ExperimentTestExecutions_Experimen~",
                table: "ExperimentTestExecutions",
                column: "ExperimentTestExecutionId",
                principalTable: "ExperimentTestExecutions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
