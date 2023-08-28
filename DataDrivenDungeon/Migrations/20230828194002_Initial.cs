using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataDrivenDungeon.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Armors",
                columns: table => new
                {
                    ArmorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArmorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArmorCost = table.Column<short>(type: "smallint", nullable: false),
                    ArmorHealthMax = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armors", x => x.ArmorId);
                });

            migrationBuilder.CreateTable(
                name: "Dungeons",
                columns: table => new
                {
                    DungeonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DungeonName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FightsBeforeBoss = table.Column<short>(type: "smallint", nullable: false),
                    EnemyMinPerFight = table.Column<short>(type: "smallint", nullable: false),
                    ExtraEnemyChance = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dungeons", x => x.DungeonId);
                });

            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    WeaponId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WeaponName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WeaponCost = table.Column<short>(type: "smallint", nullable: false),
                    DamageMin = table.Column<short>(type: "smallint", nullable: false),
                    DamageMax = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.WeaponId);
                });

            migrationBuilder.CreateTable(
                name: "Creatures",
                columns: table => new
                {
                    CreatureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FightInDungeonDungeonId = table.Column<int>(type: "int", nullable: false),
                    CreatureName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsBoss = table.Column<bool>(type: "bit", nullable: false),
                    HealthMin = table.Column<short>(type: "smallint", nullable: false),
                    HealthMax = table.Column<short>(type: "smallint", nullable: false),
                    DamageMin = table.Column<short>(type: "smallint", nullable: false),
                    DamageMax = table.Column<short>(type: "smallint", nullable: false),
                    CoinDropMin = table.Column<short>(type: "smallint", nullable: false),
                    CoinDropMax = table.Column<short>(type: "smallint", nullable: false),
                    BonusDrop = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BonusDropChance = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Creatures", x => x.CreatureId);
                    table.ForeignKey(
                        name: "FK_Creatures_Dungeons_FightInDungeonDungeonId",
                        column: x => x.FightInDungeonDungeonId,
                        principalTable: "Dungeons",
                        principalColumn: "DungeonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Game",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    CurrentWeaponWeaponId = table.Column<int>(type: "int", nullable: false),
                    CurrentArmorArmorId = table.Column<int>(type: "int", nullable: false),
                    PlayerHealth = table.Column<short>(type: "smallint", nullable: false),
                    HighestDungeonAllowedDungeonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game", x => x.GameId);
                    table.ForeignKey(
                        name: "FK_Game_Armors_CurrentArmorArmorId",
                        column: x => x.CurrentArmorArmorId,
                        principalTable: "Armors",
                        principalColumn: "ArmorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Game_Dungeons_HighestDungeonAllowedDungeonId",
                        column: x => x.HighestDungeonAllowedDungeonId,
                        principalTable: "Dungeons",
                        principalColumn: "DungeonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Game_Weapons_CurrentWeaponWeaponId",
                        column: x => x.CurrentWeaponWeaponId,
                        principalTable: "Weapons",
                        principalColumn: "WeaponId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GameInventory",
                columns: table => new
                {
                    InventoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SaveDataGameId = table.Column<int>(type: "int", nullable: false),
                    Coins = table.Column<short>(type: "smallint", nullable: false),
                    BankedCoins = table.Column<short>(type: "smallint", nullable: false),
                    Potions = table.Column<short>(type: "smallint", nullable: false),
                    BankedPotions = table.Column<short>(type: "smallint", nullable: false),
                    Fireballs = table.Column<short>(type: "smallint", nullable: false),
                    BankedFireballs = table.Column<short>(type: "smallint", nullable: false),
                    Emblems = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameInventory", x => x.InventoryId);
                    table.ForeignKey(
                        name: "FK_GameInventory_Game_SaveDataGameId",
                        column: x => x.SaveDataGameId,
                        principalTable: "Game",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Creatures_FightInDungeonDungeonId",
                table: "Creatures",
                column: "FightInDungeonDungeonId");

            migrationBuilder.CreateIndex(
                name: "IX_Game_CurrentArmorArmorId",
                table: "Game",
                column: "CurrentArmorArmorId");

            migrationBuilder.CreateIndex(
                name: "IX_Game_CurrentWeaponWeaponId",
                table: "Game",
                column: "CurrentWeaponWeaponId");

            migrationBuilder.CreateIndex(
                name: "IX_Game_HighestDungeonAllowedDungeonId",
                table: "Game",
                column: "HighestDungeonAllowedDungeonId");

            migrationBuilder.CreateIndex(
                name: "IX_GameInventory_SaveDataGameId",
                table: "GameInventory",
                column: "SaveDataGameId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Creatures");

            migrationBuilder.DropTable(
                name: "GameInventory");

            migrationBuilder.DropTable(
                name: "Game");

            migrationBuilder.DropTable(
                name: "Armors");

            migrationBuilder.DropTable(
                name: "Dungeons");

            migrationBuilder.DropTable(
                name: "Weapons");
        }
    }
}
