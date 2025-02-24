using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace WebLab.Migrations
{
    /// <inheritdoc />
    public partial class AddKeyPadEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KeyPads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    KeyPadType = table.Column<string>(type: "text", nullable: false),
                    Length = table.Column<int>(type: "integer", nullable: false),
                    Width = table.Column<int>(type: "integer", nullable: false),
                    Weight = table.Column<int>(type: "integer", nullable: false),
                    ConnectionType = table.Column<string>(type: "text", nullable: false),
                    TouchType = table.Column<string>(type: "text", nullable: false),
                    EnergyType = table.Column<string>(type: "text", nullable: false),
                    KeyPadLayout = table.Column<string>(type: "text", nullable: false),
                    GraphicCardModel = table.Column<string>(type: "text", nullable: false),
                    SignalTransmission = table.Column<string>(type: "text", nullable: false),
                    BatteryTime = table.Column<int>(type: "integer", nullable: false),
                    ProductId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeyPads", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KeyPads_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KeyPads_ProductId",
                table: "KeyPads",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KeyPads");
        }
    }
}
