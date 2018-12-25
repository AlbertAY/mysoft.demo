using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mysoft.Demo.Web.Migrations
{
    public partial class 新增材料类型 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ProductTypeGUID",
                table: "Products",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    ProductTypeGUID = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.ProductTypeGUID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductTypeGUID",
                table: "Products",
                column: "ProductTypeGUID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductTypes_ProductTypeGUID",
                table: "Products",
                column: "ProductTypeGUID",
                principalTable: "ProductTypes",
                principalColumn: "ProductTypeGUID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductTypes_ProductTypeGUID",
                table: "Products");

            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductTypeGUID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductTypeGUID",
                table: "Products");
        }
    }
}
