using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebLab.Migrations
{
    /// <inheritdoc />
    public partial class ChangeNullable_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "NumberOnSettings",
                table: "UserBehaviours",
                type: "integer",
                nullable: true);
            
            
            migrationBuilder.AlterColumn<int>(
                name: "NumberClickedOnHelp",
                table: "UserBehaviours",
                type: "integer",
                nullable: true);
            
            
            migrationBuilder.AlterColumn<int>(
                name: "TimeReadingWelcomeModel",
                table: "UserBehaviours",
                type: "integer",
                nullable: true);
            
            migrationBuilder.AlterColumn<int>(
                name: "ClickedOnSettings",
                table: "UserBehaviours",
                type: "boolean",
                nullable: true);
            
            migrationBuilder.AlterColumn<int>(
                name: "ClickedOnHelp",
                table: "UserBehaviours",
                type: "boolean",
                nullable: true);


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "NumberOnSettings",
                table: "UserBehaviours",
                type: "integer",
                nullable: true);
            
            
            migrationBuilder.AlterColumn<int>(
                name: "TimeReadingWelcomeModel",
                table: "UserBehaviours",
                type: "integer",
                nullable: true);
            
            migrationBuilder.AlterColumn<int>(
                name: "NumberClickedOnHelp",
                table: "UserBehaviours",
                type: "integer",
                nullable: true);
            
            
            migrationBuilder.AlterColumn<int>(
                name: "ClickedOnSettings",
                table: "UserBehaviours",
                type: "boolean",
                nullable: true);
            
            migrationBuilder.AlterColumn<int>(
                name: "ClickedOnHelp",
                table: "UserBehaviours",
                type: "boolean",
                nullable: true);



        }
    }
}
