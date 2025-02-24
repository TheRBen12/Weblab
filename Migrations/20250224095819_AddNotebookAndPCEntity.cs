using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace WebLab.Migrations
{
    /// <inheritdoc />
    public partial class AddNotebookAndPCEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Trademark = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notebooks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ram = table.Column<int>(type: "integer", nullable: false),
                    StorageCapacity = table.Column<int>(type: "integer", nullable: false),
                    Os = table.Column<string>(type: "text", nullable: false),
                    KeyPadFormat = table.Column<string>(type: "text", nullable: false),
                    ProcessorType = table.Column<string>(type: "text", nullable: false),
                    NumberProcessorCores = table.Column<int>(type: "integer", nullable: false),
                    GraphicCardModel = table.Column<string>(type: "text", nullable: false),
                    NumberPerformanceCors = table.Column<int>(type: "integer", nullable: false),
                    MaxBatteryTime = table.Column<int>(type: "integer", nullable: false),
                    NumberUsbAdapters = table.Column<int>(type: "integer", nullable: false),
                    ProductId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notebooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notebooks_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonalComputers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ram = table.Column<int>(type: "integer", nullable: false),
                    StorageCapacity = table.Column<int>(type: "integer", nullable: false),
                    Os = table.Column<string>(type: "text", nullable: false),
                    KeyPadFormat = table.Column<string>(type: "text", nullable: false),
                    ProcessorType = table.Column<string>(type: "text", nullable: false),
                    NumberProcessorCores = table.Column<int>(type: "integer", nullable: false),
                    GraphicCardModel = table.Column<string>(type: "text", nullable: false),
                    NumberPerformanceCors = table.Column<int>(type: "integer", nullable: false),
                    ClockFrequency = table.Column<float>(type: "real", nullable: false),
                    NumberUsbAdapters = table.Column<int>(type: "integer", nullable: false),
                    Cache = table.Column<int>(type: "integer", nullable: false),
                    ProductId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalComputers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonalComputers_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Notebooks_ProductId",
                table: "Notebooks",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalComputers_ProductId",
                table: "PersonalComputers",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notebooks");

            migrationBuilder.DropTable(
                name: "PersonalComputers");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
