using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace WebLab.Migrations
{
    /// <inheritdoc />
    public partial class AddFittLawExperiment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FittsLawExperimentExecutions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ExperimentTestExecutionId = table.Column<int>(type: "integer", nullable: false),
                    ClickReactionTimes = table.Column<string>(type: "text", nullable: false),
                    NumberFailedClicks = table.Column<int>(type: "integer", nullable: false),
                    ExecutionTime = table.Column<int>(type: "integer", nullable: false),
                    Tasks = table.Column<string>(type: "text", nullable: false),
                    TaskSuccess = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FittsLawExperimentExecutions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FittsLawExperimentExecutions_ExperimentTestExecutions_Exper~",
                        column: x => x.ExperimentTestExecutionId,
                        principalTable: "ExperimentTestExecutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FittsLawExperimentExecutions_ExperimentTestExecutionId",
                table: "FittsLawExperimentExecutions",
                column: "ExperimentTestExecutionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FittsLawExperimentExecutions");
        }
    }
}
