using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebLab.Migrations
{
    /// <inheritdoc />
    public partial class RemoveTypeProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductTypes_ProductTypes_ParentTypeId",
                table: "ProductTypes");

            migrationBuilder.DropIndex(
                name: "IX_ProductTypes_ParentTypeId",
                table: "ProductTypes");

            migrationBuilder.DropColumn(
                name: "ParentTypeId",
                table: "ProductTypes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParentTypeId",
                table: "ProductTypes",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductTypes_ParentTypeId",
                table: "ProductTypes",
                column: "ParentTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTypes_ProductTypes_ParentTypeId",
                table: "ProductTypes",
                column: "ParentTypeId",
                principalTable: "ProductTypes",
                principalColumn: "Id");
        }
    }
}
