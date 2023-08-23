using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataDrivenDungeon.Migrations
{
    /// <inheritdoc />
    public partial class Secondary : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameInventory_Game_SaveDataGameId",
                table: "GameInventory");

            migrationBuilder.DropIndex(
                name: "IX_GameInventory_SaveDataGameId",
                table: "GameInventory");

            migrationBuilder.DropColumn(
                name: "SaveDataGameId",
                table: "GameInventory");

            migrationBuilder.AddColumn<int>(
                name: "InventoryId",
                table: "Game",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InventoryId",
                table: "Game");

            migrationBuilder.AddColumn<int>(
                name: "SaveDataGameId",
                table: "GameInventory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_GameInventory_SaveDataGameId",
                table: "GameInventory",
                column: "SaveDataGameId");

            migrationBuilder.AddForeignKey(
                name: "FK_GameInventory_Game_SaveDataGameId",
                table: "GameInventory",
                column: "SaveDataGameId",
                principalTable: "Game",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
