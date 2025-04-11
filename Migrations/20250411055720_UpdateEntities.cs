using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace WebLab.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberToggledMenu",
                table: "MentalModelExperimentExecutions",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ExperimentTestSelectionTimes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Time = table.Column<int>(type: "integer", nullable: false),
                    ExperimentTestId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    SettingId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExperimentTestSelectionTimes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExperimentTestSelectionTimes_ExperimentTests_ExperimentTest~",
                        column: x => x.ExperimentTestId,
                        principalTable: "ExperimentTests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExperimentTestSelectionTimes_UserSettings_SettingId",
                        column: x => x.SettingId,
                        principalTable: "UserSettings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExperimentTestSelectionTimes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExperimentTestSelectionTimes_ExperimentTestId",
                table: "ExperimentTestSelectionTimes",
                column: "ExperimentTestId");

            migrationBuilder.CreateIndex(
                name: "IX_ExperimentTestSelectionTimes_SettingId",
                table: "ExperimentTestSelectionTimes",
                column: "SettingId");

            migrationBuilder.CreateIndex(
                name: "IX_ExperimentTestSelectionTimes_UserId",
                table: "ExperimentTestSelectionTimes",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExperimentTestSelectionTimes");

            migrationBuilder.DropColumn(
                name: "NumberToggledMenu",
                table: "MentalModelExperimentExecutions");
        }
    }
}
