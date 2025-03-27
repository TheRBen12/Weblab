using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace WebLab.Migrations
{
    /// <inheritdoc />
    public partial class AddErrorCorrectionExperiment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ErrorCorrectionExperimentExecutions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ExperimentTestExecutionId = table.Column<int>(type: "integer", nullable: false),
                    FailedClicks = table.Column<int>(type: "integer", nullable: false),
                    ExecutionTime = table.Column<double>(type: "double precision", nullable: true),
                    NumberClicks = table.Column<int>(type: "integer", nullable: true),
                    FirstClick = table.Column<string>(type: "text", nullable: false),
                    TimeToClickOnUndo = table.Column<int>(type: "integer", nullable: true),
                    ClickedOnUndo = table.Column<bool>(type: "boolean", nullable: false),
                    TaskSuccess = table.Column<bool>(type: "boolean", nullable: false),
                    ClickedOnDeletedItems = table.Column<bool>(type: "boolean", nullable: false),
                    UndoSnackBarPosition = table.Column<string>(type: "text", nullable: false),
                    CorrectInput = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ErrorCorrectionExperimentExecutions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ErrorCorrectionExperimentExecutions_ExperimentTestExecution~",
                        column: x => x.ExperimentTestExecutionId,
                        principalTable: "ExperimentTestExecutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ErrorCorrectionExperimentExecutions_ExperimentTestExecution~",
                table: "ErrorCorrectionExperimentExecutions",
                column: "ExperimentTestExecutionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ErrorCorrectionExperimentExecutions");
        }
    }
}
