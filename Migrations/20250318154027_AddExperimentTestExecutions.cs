using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace WebLab.Migrations
{
    /// <inheritdoc />
    public partial class AddExperimentTestExecutions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExperimentTestExecutions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ExperimentTestId = table.Column<int>(type: "integer", nullable: false),
                    FinishedExecutionAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    StartedExecutionAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    ExecutionTime = table.Column<double>(type: "double precision", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    Discriminator = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: false),
                    ExperimentTestExecutionId = table.Column<int>(type: "integer", nullable: true),
                    CategoryLinkClickDates = table.Column<string>(type: "text", nullable: true),
                    FailedClicks = table.Column<int>(type: "integer", nullable: true),
                    ClickedOnSearchBar = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExperimentTestExecutions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExperimentTestExecutions_ExperimentTestExecutions_Experimen~",
                        column: x => x.ExperimentTestExecutionId,
                        principalTable: "ExperimentTestExecutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExperimentTestExecutions_ExperimentTests_ExperimentTestId",
                        column: x => x.ExperimentTestId,
                        principalTable: "ExperimentTests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExperimentTestExecutions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExperimentTestExecutions_ExperimentTestExecutionId",
                table: "ExperimentTestExecutions",
                column: "ExperimentTestExecutionId");

            migrationBuilder.CreateIndex(
                name: "IX_ExperimentTestExecutions_ExperimentTestId",
                table: "ExperimentTestExecutions",
                column: "ExperimentTestId");

            migrationBuilder.CreateIndex(
                name: "IX_ExperimentTestExecutions_UserId",
                table: "ExperimentTestExecutions",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExperimentTestExecutions");
        }
    }
}
