using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace WebLab.Migrations
{
    /// <inheritdoc />
    public partial class AddHicksLawExperimentExecution : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HicksLawExperimentExecutions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ExperimentTestExecutionId = table.Column<int>(type: "integer", nullable: false),
                    CategoryLinkClickDates = table.Column<string>(type: "text", nullable: true),
                    FailedClicks = table.Column<int>(type: "integer", nullable: false),
                    ExecutionTime = table.Column<double>(type: "double precision", nullable: true),
                    NumberClicks = table.Column<int>(type: "integer", nullable: true),
                    NumberUsedSearchBar = table.Column<int>(type: "integer", nullable: true),
                    ProductLimit = table.Column<int>(type: "integer", nullable: false),
                    CategoryLimit = table.Column<int>(type: "integer", nullable: false),
                    ClickedOnFilters = table.Column<bool>(type: "boolean", nullable: false),
                    FirstChoiceAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    SecondChoiceAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    ThirdChoiceAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HicksLawExperimentExecutions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HicksLawExperimentExecutions_ExperimentTestExecutions_Exper~",
                        column: x => x.ExperimentTestExecutionId,
                        principalTable: "ExperimentTestExecutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HicksLawExperimentExecutions_ExperimentTestExecutionId",
                table: "HicksLawExperimentExecutions",
                column: "ExperimentTestExecutionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HicksLawExperimentExecutions");
        }
    }
}
