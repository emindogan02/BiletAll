using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BiletAll.Entity.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Firmalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirmaNo = table.Column<int>(type: "int", nullable: false),
                    FirmaAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firmalar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Yolcular",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TcNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cinsiyet = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yolcular", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Seferler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KalkisNokta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VarisNokta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VarisTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KalkisTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SeferTipi = table.Column<int>(type: "int", nullable: true),
                    Peron = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YaklasikVarisSuresi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirmaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seferler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Seferler_Firmalar_FirmaId",
                        column: x => x.FirmaId,
                        principalTable: "Firmalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pnrlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IslemTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PnrNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeferId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pnrlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pnrlar_Seferler_SeferId",
                        column: x => x.SeferId,
                        principalTable: "Seferler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PnrYolcular",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KoltukNo = table.Column<int>(type: "int", nullable: true),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Durum = table.Column<int>(type: "int", nullable: true),
                    PnrId = table.Column<int>(type: "int", nullable: false),
                    YolcuId = table.Column<int>(type: "int", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PnrYolcular", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PnrYolcular_Pnrlar_PnrId",
                        column: x => x.PnrId,
                        principalTable: "Pnrlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PnrYolcular_Yolcular_YolcuId",
                        column: x => x.YolcuId,
                        principalTable: "Yolcular",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pnrlar_SeferId",
                table: "Pnrlar",
                column: "SeferId");

            migrationBuilder.CreateIndex(
                name: "IX_PnrYolcular_PnrId",
                table: "PnrYolcular",
                column: "PnrId");

            migrationBuilder.CreateIndex(
                name: "IX_PnrYolcular_YolcuId",
                table: "PnrYolcular",
                column: "YolcuId");

            migrationBuilder.CreateIndex(
                name: "IX_Seferler_FirmaId",
                table: "Seferler",
                column: "FirmaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PnrYolcular");

            migrationBuilder.DropTable(
                name: "Pnrlar");

            migrationBuilder.DropTable(
                name: "Yolcular");

            migrationBuilder.DropTable(
                name: "Seferler");

            migrationBuilder.DropTable(
                name: "Firmalar");
        }
    }
}
