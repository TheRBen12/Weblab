using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebLab.Migrations
{
    /// <inheritdoc />
    public partial class Change : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notebooks_ProductTypes_TypeId",
                table: "Notebooks");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSpecifications_ProductTypes_ProductTypeId",
                table: "ProductSpecifications");

            migrationBuilder.DropIndex(
                name: "IX_Notebooks_TypeId",
                table: "Notebooks");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Notebooks");

            migrationBuilder.AddColumn<int>(
                name: "ProductTypeId1",
                table: "ProductSpecifications",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Value",
                table: "ProductSpecifications",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSpecifications_ProductTypeId1",
                table: "ProductSpecifications",
                column: "ProductTypeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSpecifications_ProductTypes_ProductTypeId1",
                table: "ProductSpecifications",
                column: "ProductTypeId1",
                principalTable: "ProductTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSpecifications_Products_ProductTypeId",
                table: "ProductSpecifications",
                column: "ProductTypeId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductSpecifications_ProductTypes_ProductTypeId1",
                table: "ProductSpecifications");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSpecifications_Products_ProductTypeId",
                table: "ProductSpecifications");

            migrationBuilder.DropIndex(
                name: "IX_ProductSpecifications_ProductTypeId1",
                table: "ProductSpecifications");

            migrationBuilder.DropColumn(
                name: "ProductTypeId1",
                table: "ProductSpecifications");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "ProductSpecifications");

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "Notebooks",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Notebooks_TypeId",
                table: "Notebooks",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notebooks_ProductTypes_TypeId",
                table: "Notebooks",
                column: "TypeId",
                principalTable: "ProductTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSpecifications_ProductTypes_ProductTypeId",
                table: "ProductSpecifications",
                column: "ProductTypeId",
                principalTable: "ProductTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
