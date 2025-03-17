using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace WebLab.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUserEntityAndAddedUserBehaviourEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserBehaviours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClickedOnHelp = table.Column<bool>(type: "boolean", nullable: false),
                    NumberClickedOnHelp = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    ClickedOnSettings = table.Column<bool>(type: "boolean", nullable: false),
                    NumberOnSettings = table.Column<int>(type: "integer", nullable: false),
                    TimeReadingWelcomeModel = table.Column<int>(type: "integer", nullable: false),
                    ClickedOnHint = table.Column<bool>(type: "boolean", nullable: false),
                    NumberClickedOnHint = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBehaviours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserBehaviours_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserBehaviours_UserId",
                table: "UserBehaviours",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserBehaviours");
        }
    }
}
