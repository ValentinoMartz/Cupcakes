using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cupcakes.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bakeries",
                columns: table => new
                {
                    BakeryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BakeryName = table.Column<string>(maxLength: 50, nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    Address = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bakeries", x => x.BakeryId);
                });

            migrationBuilder.CreateTable(
                name: "Cupcakes",
                columns: table => new
                {
                    CupcakeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CupcakeType = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    GlutenFree = table.Column<bool>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    ImageName = table.Column<string>(nullable: true),
                    PhotoFile = table.Column<byte[]>(nullable: true),
                    ImageMimeType = table.Column<string>(nullable: true),
                    BakeryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cupcakes", x => x.CupcakeId);
                    table.ForeignKey(
                        name: "FK_Cupcakes_Bakeries_BakeryId",
                        column: x => x.BakeryId,
                        principalTable: "Bakeries",
                        principalColumn: "BakeryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cupcakes_BakeryId",
                table: "Cupcakes",
                column: "BakeryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cupcakes");

            migrationBuilder.DropTable(
                name: "Bakeries");
        }
    }
}
