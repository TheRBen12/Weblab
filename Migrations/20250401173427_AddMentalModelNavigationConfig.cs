using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace WebLab.Migrations
{
    /// <inheritdoc />
    public partial class AddMentalModelNavigationConfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MentalModelNavigationConfigs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SearchBarTop = table.Column<bool>(type: "boolean", nullable: false),
                    SearchBarBottom = table.Column<bool>(type: "boolean", nullable: false),
                    NavBarTop = table.Column<bool>(type: "boolean", nullable: false),
                    NavBarBottom = table.Column<bool>(type: "boolean", nullable: false),
                    Filter = table.Column<bool>(type: "boolean", nullable: false),
                    AutoCompleteBottom = table.Column<bool>(type: "boolean", nullable: false),
                    AutoCompleteTop = table.Column<bool>(type: "boolean", nullable: false),
                    ShoppingCartTopLeft = table.Column<bool>(type: "boolean", nullable: false),
                    ShoppingCartTopRight = table.Column<bool>(type: "boolean", nullable: false),
                    ShoppingCartBottomRight = table.Column<bool>(type: "boolean", nullable: false),
                    ShoppingCartBottomRLeft = table.Column<bool>(type: "boolean", nullable: false),
                    MegaDropDown = table.Column<bool>(type: "boolean", nullable: false),
                    SideMenuLeft = table.Column<bool>(type: "boolean", nullable: false),
                    SideMenuRight = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MentalModelNavigationConfigs", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MentalModelNavigationConfigs");
        }
    }
}
