﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ForgeShopDatabaseImplement.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Billets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BilletName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Billets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ForgeProducts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ForgeProductName = table.Column<string>(nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForgeProducts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ForgeProductBillets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ForgeProductId = table.Column<int>(nullable: false),
                    BilletId = table.Column<int>(nullable: false),
                    Count = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForgeProductBillets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ForgeProductBillets_Billets_BilletId",
                        column: x => x.BilletId,
                        principalTable: "Billets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ForgeProductBillets_ForgeProducts_ForgeProductId",
                        column: x => x.ForgeProductId,
                        principalTable: "ForgeProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ForgeProductId = table.Column<int>(nullable: false),
                    Count = table.Column<int>(nullable: false),
                    Sum = table.Column<decimal>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    DateImplement = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_ForgeProducts_ForgeProductId",
                        column: x => x.ForgeProductId,
                        principalTable: "ForgeProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ForgeProductBillets_BilletId",
                table: "ForgeProductBillets",
                column: "BilletId");

            migrationBuilder.CreateIndex(
                name: "IX_ForgeProductBillets_ForgeProductId",
                table: "ForgeProductBillets",
                column: "ForgeProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ForgeProductId",
                table: "Orders",
                column: "ForgeProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ForgeProductBillets");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Billets");

            migrationBuilder.DropTable(
                name: "ForgeProducts");
        }
    }
}
