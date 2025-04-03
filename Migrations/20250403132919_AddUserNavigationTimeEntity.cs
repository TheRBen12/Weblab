using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace WebLab.Migrations
{
    /// <inheritdoc />
    public partial class AddUserNavigationTimeEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserNavigationTimes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    FromExperimentId = table.Column<int>(type: "integer", nullable: true),
                    ToExperimentId = table.Column<int>(type: "integer", nullable: false),
                    FinishedNavigation = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    StartedNavigation = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UserSettingId = table.Column<int>(type: "integer", nullable: false),
                    NumberClicks = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserNavigationTimes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserNavigationTimes_Experiments_FromExperimentId",
                        column: x => x.FromExperimentId,
                        principalTable: "Experiments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserNavigationTimes_Experiments_ToExperimentId",
                        column: x => x.ToExperimentId,
                        principalTable: "Experiments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserNavigationTimes_UserSettings_UserSettingId",
                        column: x => x.UserSettingId,
                        principalTable: "UserSettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserNavigationTimes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserNavigationTimes_FromExperimentId",
                table: "UserNavigationTimes",
                column: "FromExperimentId");

            migrationBuilder.CreateIndex(
                name: "IX_UserNavigationTimes_ToExperimentId",
                table: "UserNavigationTimes",
                column: "ToExperimentId");

            migrationBuilder.CreateIndex(
                name: "IX_UserNavigationTimes_UserId",
                table: "UserNavigationTimes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserNavigationTimes_UserSettingId",
                table: "UserNavigationTimes",
                column: "UserSettingId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserNavigationTimes");
        }
    }
}
