using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebLab.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEntitiesProductType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductCategory",
                table: "Notebooks");

            migrationBuilder.DropColumn(
                name: "ProductCategory",
                table: "KeyPads");

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "PersonalComputers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "Notebooks",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "KeyPads",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PersonalComputers_TypeId",
                table: "PersonalComputers",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Notebooks_TypeId",
                table: "Notebooks",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_KeyPads_TypeId",
                table: "KeyPads",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_KeyPads_ProductTypes_TypeId",
                table: "KeyPads",
                column: "TypeId",
                principalTable: "ProductTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notebooks_ProductTypes_TypeId",
                table: "Notebooks",
                column: "TypeId",
                principalTable: "ProductTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalComputers_ProductTypes_TypeId",
                table: "PersonalComputers",
                column: "TypeId",
                principalTable: "ProductTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KeyPads_ProductTypes_TypeId",
                table: "KeyPads");

            migrationBuilder.DropForeignKey(
                name: "FK_Notebooks_ProductTypes_TypeId",
                table: "Notebooks");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonalComputers_ProductTypes_TypeId",
                table: "PersonalComputers");

            migrationBuilder.DropIndex(
                name: "IX_PersonalComputers_TypeId",
                table: "PersonalComputers");

            migrationBuilder.DropIndex(
                name: "IX_Notebooks_TypeId",
                table: "Notebooks");

            migrationBuilder.DropIndex(
                name: "IX_KeyPads_TypeId",
                table: "KeyPads");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "PersonalComputers");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Notebooks");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "KeyPads");

            migrationBuilder.AddColumn<string>(
                name: "ProductCategory",
                table: "Notebooks",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProductCategory",
                table: "KeyPads",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
