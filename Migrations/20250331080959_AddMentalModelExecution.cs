using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace WebLab.Migrations
{
    /// <inheritdoc />
    public partial class AddMentalModelExecution : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MentalModelExperimentExecutions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ExperimentTestExecutionId = table.Column<int>(type: "integer", nullable: false),
                    ClickedRoutes = table.Column<string>(type: "text", nullable: true),
                    FailedClicks = table.Column<int>(type: "integer", nullable: false),
                    ClickedOnSearchBar = table.Column<bool>(type: "boolean", nullable: false),
                    UsedFilters = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    FirstClick = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    UsedFilter = table.Column<bool>(type: "boolean", nullable: false),
                    ExecutionTime = table.Column<double>(type: "double precision", nullable: true),
                    NumberClicks = table.Column<int>(type: "integer", nullable: true),
                    NumberUsedSearchBar = table.Column<int>(type: "integer", nullable: true),
                    TimeToClickFirstCategory = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MentalModelExperimentExecutions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MentalModelExperimentExecutions_ExperimentTestExecutions_Ex~",
                        column: x => x.ExperimentTestExecutionId,
                        principalTable: "ExperimentTestExecutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MentalModelExperimentExecutions_ExperimentTestExecutionId",
                table: "MentalModelExperimentExecutions",
                column: "ExperimentTestExecutionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MentalModelExperimentExecutions");
        }
    }
}
