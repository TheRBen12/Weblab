using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebLab.Migrations
{
    /// <inheritdoc />
    public partial class AddSpec : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductSpecifications_Products_ProductId",
                table: "ProductSpecifications");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "ProductSpecifications",
                newName: "ProductTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSpecifications_ProductId",
                table: "ProductSpecifications",
                newName: "IX_ProductSpecifications_ProductTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSpecifications_ProductTypes_ProductTypeId",
                table: "ProductSpecifications",
                column: "ProductTypeId",
                principalTable: "ProductTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductSpecifications_ProductTypes_ProductTypeId",
                table: "ProductSpecifications");

            migrationBuilder.RenameColumn(
                name: "ProductTypeId",
                table: "ProductSpecifications",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSpecifications_ProductTypeId",
                table: "ProductSpecifications",
                newName: "IX_ProductSpecifications_ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSpecifications_Products_ProductId",
                table: "ProductSpecifications",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
