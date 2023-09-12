using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Store.API.Migrations
{
    /// <inheritdoc />
    public partial class StoreDb_Initial_Version : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tb_category",
                columns: table => new
                {
                    PK_CAT = table.Column<uint>(type: "int unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ST_CAT_NAME = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_category", x => x.PK_CAT);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tb_selling",
                columns: table => new
                {
                    PK_SEL = table.Column<uint>(type: "int unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DB_SEL_PRICE = table.Column<double>(type: "double", nullable: false),
                    DT_SEL_START_AT = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DT_SEL_END_AT = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_selling", x => x.PK_SEL);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tb_product",
                columns: table => new
                {
                    PK_PRO = table.Column<uint>(type: "int unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ST_PRO_NAME = table.Column<string>(type: "VARCHAR(30)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DB_PRO_SALE_PRICE = table.Column<double>(type: "double", nullable: false),
                    DB_PRO_PURCHASE_PRICE = table.Column<double>(type: "double", nullable: false),
                    IN_PRO_STORAGE = table.Column<int>(type: "int", nullable: false),
                    FK_CAT_PRO = table.Column<uint>(type: "int unsigned", nullable: false),
                    DT_PRO_CREATED_AT = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DT_PRO_UPDATED_AT = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_product", x => x.PK_PRO);
                    table.ForeignKey(
                        name: "FK_tb_product_tb_category_FK_CAT_PRO",
                        column: x => x.FK_CAT_PRO,
                        principalTable: "tb_category",
                        principalColumn: "PK_CAT",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tb_sell_item",
                columns: table => new
                {
                    PK_SELI = table.Column<uint>(type: "int unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FK_SEL_SELI = table.Column<uint>(type: "int unsigned", nullable: false),
                    FK_PRO_SELI = table.Column<uint>(type: "int unsigned", nullable: false),
                    IN_SELI_QUANTITY = table.Column<int>(type: "int", nullable: false),
                    DB_SELI_PRICE = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_sell_item", x => x.PK_SELI);
                    table.ForeignKey(
                        name: "FK_tb_sell_item_tb_selling_FK_SEL_SELI",
                        column: x => x.FK_SEL_SELI,
                        principalTable: "tb_selling",
                        principalColumn: "PK_SEL",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_tb_product_FK_CAT_PRO",
                table: "tb_product",
                column: "FK_CAT_PRO");

            migrationBuilder.CreateIndex(
                name: "IX_tb_sell_item_FK_SEL_SELI",
                table: "tb_sell_item",
                column: "FK_SEL_SELI");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_product");

            migrationBuilder.DropTable(
                name: "tb_sell_item");

            migrationBuilder.DropTable(
                name: "tb_category");

            migrationBuilder.DropTable(
                name: "tb_selling");
        }
    }
}
