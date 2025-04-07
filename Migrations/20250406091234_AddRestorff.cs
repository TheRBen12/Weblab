using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace WebLab.Migrations
{
    /// <inheritdoc />
    public partial class AddRestorff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RestorffExperimentExecutions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ExperimentTestExecutionId = table.Column<int>(type: "integer", nullable: false),
                    ReactionTimes = table.Column<string>(type: "text", nullable: false),
                    NumberFailedClicks = table.Column<int>(type: "integer", nullable: false),
                    NumberClicks = table.Column<int>(type: "integer", nullable: false),
                    ExecutionTime = table.Column<int>(type: "integer", nullable: false),
                    Tasks = table.Column<string>(type: "text", nullable: false),
                    NumberDeletedMails = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestorffExperimentExecutions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RestorffExperimentExecutions_ExperimentTestExecutions_Exper~",
                        column: x => x.ExperimentTestExecutionId,
                        principalTable: "ExperimentTestExecutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RestorffExperimentExecutions_ExperimentTestExecutionId",
                table: "RestorffExperimentExecutions",
                column: "ExperimentTestExecutionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RestorffExperimentExecutions");
        }
    }
}
